page 50000 CreateTestUsers
{
    PageType = API;
    Caption = 'CreateTestUsers';
    APIPublisher = 'Microsoft';
    APIGroup = 'Setup';
    APIVersion = 'beta', 'v1.0';
    EntityName = 'testUser';
    EntitySetName = 'testUsers';
    SourceTable = "Name/Value Buffer";
    DelayedInsert = true;
    SourceTableTemporary = true;

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field(id; "ID")
                {
                    Caption = 'ID';
                }
                field(name; "Name")
                {
                    Caption = 'Name';
                }
                field(value; "Value")
                {
                    Caption = 'Value';
                }
            }
        }
    }

    trigger OnInsertRecord(BelowxRec: Boolean): Boolean
    begin
        case Name of
            'CreateTestUsers':
                begin
                    CreateTestUsers(Value, 'All');
                end;
            'CreateTestUsersEssential':
                begin
                    CreateTestUsers(Value, 'Essential');
                end;
            'CreateTestUsersPremium':
                begin
                    CreateTestUsers(Value, 'Premium');
                end;
            'SetAdminUserPremium':
                begin
                    SetAdminUserPremium(Value);
                end;
            'AddMySuperUser':
                begin
                    AddMySuperUser();
                end;
        end;
    end;

    var
        AzureADPlan: Codeunit "Azure AD Plan";
        AzureADPlanTestLibrary: Codeunit "Azure AD Plan Test Library";
        DelegatedAdminUserNameTok: Label 'DELEGATEDADMIN', Locked = true;
        DelegatedAdminFullNameTxt: Label 'Delegated Administrator';
        InternalAdminUserNameTok: Label 'INTERNALADMIN', Locked = true;
        InternalAdminFullNameTxt: Label 'Internal Administrator';
        PremiumUserNameTok: Label 'PREMIUM', Locked = true;
        PremiumFullNameTxt: Label 'Premium';
        EssentialUserNameTok: Label 'ESSENTIAL', Locked = true;
        EssentialFullNameTxt: Label 'Essential';
        TeamMemberUserNameTok: Label 'TEAMMEMBER', Locked = true;
        TeamMemberFullNameTxt: Label 'Team Member';
        ExternalAccountantUserNameTok: Label 'EXTERNALACCOUNTANT', Locked = true;
        ExternalAccountantFullNameTxt: Label 'External Accountant';
        DelegatedAdminPlanTxt: Label '{00000000-0000-0000-0000-000000000007}', Locked = true;
        InternalAdminPlanTxt: Label '{62e90394-69f5-4237-9190-012177145e10}', Locked = true;
        PremiumPlanTxt: Label '{8e9002c0-a1d8-4465-b952-817d2948e6e2}', Locked = true;
        EssentialPlanTxt: Label '{920656a2-7dd8-4c83-97b6-a356414dbd36}', Locked = true;
        TeamMemberPlanTxt: Label '{d9a6391b-8970-4976-bd94-5f205007c8d8}', Locked = true;
        ExternalAccountantPlanTxt: Label '{170991d7-b98e-41c5-83d4-db2052e1795f}', Locked = true;

    local procedure SetAdminUserPremium(InputUserName: Code[50])
    var
        User: Record User;
    begin
        AssignPlanToUser(InputUserName, PremiumPlanTxt);
        AssignPlanPermissionSetsToUser(InputUserName, PremiumPlanTxt);
    end;

    local procedure CreateTestUsers(InputPassword: Text[80]; select: Text)
    begin
        CreateUsers(InputPassword, select);
        AssignPlansToUsers(select);
        AssignPlanUserGroupsToUsers(select);
    end;

    local procedure AddMySuperUser()
    begin
        CODEUNIT.Run(CODEUNIT::"Users - Create Super User");
    end;

    local procedure CreateUsers(InputPassword: Text[80]; select: Text)
    begin
        CreateUser(DelegatedAdminUserNameTok, DelegatedAdminFullNameTxt, InputPassword);
        CreateUser(InternalAdminUserNameTok, InternalAdminFullNameTxt, InputPassword);
        if (select = 'All') or (select = 'Premium') then
            CreateUser(PremiumUserNameTok, PremiumFullNameTxt, InputPassword);
        if (select = 'All') or (select = 'Essential') then
            CreateUser(EssentialUserNameTok, EssentialFullNameTxt, InputPassword);
        CreateUser(TeamMemberUserNameTok, TeamMemberFullNameTxt, InputPassword);
        CreateUser(ExternalAccountantUserNameTok, ExternalAccountantFullNameTxt, InputPassword);
    end;

    local procedure CreateUser(InputUserName: Code[50]; InputFullName: Text[80]; InputPassword: Text[80])
    var
        User: Record User;
    begin
        if UserExists(InputUserName) then
            exit;

        User.Init;
        User."User Security ID" := CreateGuid;
        User."User Name" := InputUserName;
        User."Full Name" := InputFullName;
        User.State := User.State::Enabled;
        User."License Type" := User."License Type"::"Full User";
        User.Insert(true);
        SetUserPassword(User."User Security ID", InputPassword);
        User.Get(User."User Security ID");
        User."Change Password" := false;
        User.Modify(true);
    end;

    local procedure UserExists(InputUserName: Code[50]): Boolean
    var
        User: Record User;
    begin
        User.SetRange("User Name", InputUserName);
        exit(not User.IsEmpty);
    end;

    local procedure AssignPlansToUsers(select: Text)
    begin
        AssignPlanToUser(DelegatedAdminUserNameTok, DelegatedAdminPlanTxt);
        AssignPlanToUser(InternalAdminUserNameTok, InternalAdminPlanTxt);
        if (select = 'All') or (select = 'Premium') then
            AssignPlanToUser(PremiumUserNameTok, PremiumPlanTxt);
        if (select = 'All') or (select = 'Essential') then
            AssignPlanToUser(EssentialUserNameTok, EssentialPlanTxt);
        AssignPlanToUser(TeamMemberUserNameTok, TeamMemberPlanTxt);
        AssignPlanToUser(ExternalAccountantUserNameTok, ExternalAccountantPlanTxt);
    end;

    local procedure AssignPlanToUser(InputUserName: Code[50]; InputPlanID: Guid)
    var
        User: Record User;
    begin
        if not GetUser(User, InputUserName) then
            exit;

        if AzureADPlan.IsPlanAssignedToUser(InputPlanID, User."User Security ID") then
            exit;

        AzureADPlanTestLibrary.AssignUserToPlan(User."User Security ID", InputPlanID);
    end;

    local procedure AssignPlanUserGroupsToUsers(select: Text)
    begin
        AssignPlanPermissionSetsToUser(DelegatedAdminUserNameTok, DelegatedAdminPlanTxt);
        AssignPlanPermissionSetsToUser(InternalAdminUserNameTok, InternalAdminPlanTxt);
        if (select = 'All') or (select = 'Premium') then
            AssignPlanPermissionSetsToUser(PremiumUserNameTok, PremiumPlanTxt);
        if (select = 'All') or (select = 'Essential') then
            AssignPlanPermissionSetsToUser(EssentialUserNameTok, EssentialPlanTxt);
        AssignPlanPermissionSetsToUser(TeamMemberUserNameTok, TeamMemberPlanTxt);
        AssignPlanPermissionSetsToUser(ExternalAccountantUserNameTok, ExternalAccountantPlanTxt);
    end;

    local procedure AssignPlanPermissionSetsToUser(InputUserName: Code[50]; InputPlanID: Guid)
    var
        User: Record User;
        PermissionSetInPlanBuffer: Record "Permission Set In Plan Buffer";
    begin
        if not GetUser(User, InputUserName) then
            exit;

        if not GetPlanPermissions(PermissionSetInPlanBuffer, InputPlanID) then
            exit;

        repeat
            AssignPermissionSetToUser(PermissionSetInPlanBuffer."Role ID", User."User Security ID");
        until PermissionSetInPlanBuffer.Next = 0;
    end;

    local procedure AssignPermissionSetToUser(RoleId: Code[20]; InputUserSecurityID: Guid)
    var
        AccessControl: Record "Access Control";
        AggregatePermissionSet: Record "Aggregate Permission Set";
    begin
        AggregatePermissionSet.SetRange("Role ID", RoleId);
        AggregatePermissionSet.FindFirst();

        AccessControl."Role Id" := RoleId;
        AccessControl."User Security ID" := InputUserSecurityID;
        AccessControl.Scope := AccessControl.Scope::System;
        AccessControl."App ID" := AggregatePermissionSet."App ID";
        if AccessControl.Insert() then;
    end;

    local procedure GetPlanPermissions(var PermissionSetInPlanBuffer: Record "Permission Set In Plan Buffer"; InputPlanID: Guid): Boolean
    var
        PlanConfiguration: Codeunit "Plan Configuration";
    begin
        PlanConfiguration.GetDefaultPermissions(PermissionSetInPlanBuffer);
        PermissionSetInPlanBuffer.SetRange("Plan ID", InputPlanID);
        exit(PermissionSetInPlanBuffer.FindSet());
    end;

    local procedure GetUser(var User: Record User; InputUserName: Code[50]): Boolean
    begin
        User.SetRange("User Name", InputUserName);
        exit(User.FindFirst);
    end;
}