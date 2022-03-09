namespace Microsoft.Dynamics.Nav.BusinessApplication
{
    using System;
    using Microsoft.Dynamics.Nav.Runtime;
    using Microsoft.Dynamics.Nav.Runtime.Extensions;
    using Microsoft.Dynamics.Nav.Types;
    using Microsoft.Dynamics.Nav.Types.Exceptions;
    using Microsoft.Dynamics.Nav.Types.Metadata;
    using Microsoft.Dynamics.Nav.Common.Language;
    using Microsoft.Dynamics.Nav.EventSubscription;

    public sealed class Page50000 : NavForm
    {
        [NavName("DelegatedAdminUserNameTok")]
        private NavTextConstant delegatedAdminUserNameTok = new NavTextConstant(new int[]{1033}, new string[]{"DELEGATEDADMIN"});
        [NavName("DelegatedAdminFullNameTxt")]
        private NavTextConstant delegatedAdminFullNameTxt = new NavTextConstant(new int[]{1033}, new string[]{"Delegated Administrator"});
        [NavName("InternalAdminUserNameTok")]
        private NavTextConstant internalAdminUserNameTok = new NavTextConstant(new int[]{1033}, new string[]{"INTERNALADMIN"});
        [NavName("InternalAdminFullNameTxt")]
        private NavTextConstant internalAdminFullNameTxt = new NavTextConstant(new int[]{1033}, new string[]{"Internal Administrator"});
        [NavName("PremiumUserNameTok")]
        private NavTextConstant premiumUserNameTok = new NavTextConstant(new int[]{1033}, new string[]{"PREMIUM"});
        [NavName("PremiumFullNameTxt")]
        private NavTextConstant premiumFullNameTxt = new NavTextConstant(new int[]{1033}, new string[]{"Premium"});
        [NavName("EssentialUserNameTok")]
        private NavTextConstant essentialUserNameTok = new NavTextConstant(new int[]{1033}, new string[]{"ESSENTIAL"});
        [NavName("EssentialFullNameTxt")]
        private NavTextConstant essentialFullNameTxt = new NavTextConstant(new int[]{1033}, new string[]{"Essential"});
        [NavName("TeamMemberUserNameTok")]
        private NavTextConstant teamMemberUserNameTok = new NavTextConstant(new int[]{1033}, new string[]{"TEAMMEMBER"});
        [NavName("TeamMemberFullNameTxt")]
        private NavTextConstant teamMemberFullNameTxt = new NavTextConstant(new int[]{1033}, new string[]{"Team Member"});
        [NavName("ExternalAccountantUserNameTok")]
        private NavTextConstant externalAccountantUserNameTok = new NavTextConstant(new int[]{1033}, new string[]{"EXTERNALACCOUNTANT"});
        [NavName("ExternalAccountantFullNameTxt")]
        private NavTextConstant externalAccountantFullNameTxt = new NavTextConstant(new int[]{1033}, new string[]{"External Accountant"});
        [NavName("DelegatedAdminPlanTxt")]
        private NavTextConstant delegatedAdminPlanTxt = new NavTextConstant(new int[]{1033}, new string[]{"{00000000-0000-0000-0000-000000000007}"});
        [NavName("InternalAdminPlanTxt")]
        private NavTextConstant internalAdminPlanTxt = new NavTextConstant(new int[]{1033}, new string[]{"{62e90394-69f5-4237-9190-012177145e10}"});
        [NavName("PremiumPlanTxt")]
        private NavTextConstant premiumPlanTxt = new NavTextConstant(new int[]{1033}, new string[]{"{8e9002c0-a1d8-4465-b952-817d2948e6e2}"});
        [NavName("EssentialPlanTxt")]
        private NavTextConstant essentialPlanTxt = new NavTextConstant(new int[]{1033}, new string[]{"{920656a2-7dd8-4c83-97b6-a356414dbd36}"});
        [NavName("TeamMemberPlanTxt")]
        private NavTextConstant teamMemberPlanTxt = new NavTextConstant(new int[]{1033}, new string[]{"{d9a6391b-8970-4976-bd94-5f205007c8d8}"});
        [NavName("ExternalAccountantPlanTxt")]
        private NavTextConstant externalAccountantPlanTxt = new NavTextConstant(new int[]{1033}, new string[]{"{170991d7-b98e-41c5-83d4-db2052e1795f}"});
        public Page50000(ITreeObject parent): base (parent, 50000)
        {
            this.InitializeComponent();
        }

        public Page50000(ITreeObject parent, NavRecord record): base (parent, 50000, record)
        {
            this.InitializeComponent();
        }

        void InitializeComponent()
        {
            this.CallInitializeComponentExtensionMethod();
            this.InitializeForm();
        }

        public override string ObjectName
        {
            get
            {
                return "CreateTestUsers";
            }
        }

        private NavRecord Rec
        {
            get
            {
                return (NavRecord)this.SourceTable;
            }
        }

        private NavRecord xRec
        {
            get
            {
                return (NavRecord)this.OldRecord;
            }
        }

        private Page50000 CurrPage
        {
            get
            {
                return (Page50000)this;
            }
        }

        public override string EvaluateCaptionClass(int fieldNo)
        {
            this.EnsureGlobalVariablesInitialized();
            string result = null;
            if (this.CallEvaluateCaptionClassExtensionMethod(fieldNo, ref result))
                return result;
            switch (fieldNo)
            {
                case 431615187:
                    return Rec.EvaluateCaptionClass(1);
                case 744020215:
                    return Rec.EvaluateCaptionClass(2);
                case 169460371:
                    return Rec.EvaluateCaptionClass(3);
            }

            return string.Empty;
        }

        protected override void OnMetadataLoaded()
        {
            this.CallOnMetadataLoadedExtensionMethod();
            this.RegisterDynamicCaptionExpression(431615187);
            this.RegisterDynamicCaptionExpression(744020215);
            this.RegisterDynamicCaptionExpression(169460371);
        }

        protected override string GetAutoFormatString(int fieldNo)
        {
            string result = null;
            if (this.CallGetAutoFormatStringExtensionMethod(fieldNo, ref result))
                return result;
            return string.Empty;
        }

        protected override string GetDecimalPlaces(int fieldNo)
        {
            string result = null;
            if (this.CallGetDecimalPlacesExtensionMethod(fieldNo, ref result))
                return result;
            return string.Empty;
        }

        public static Page50000 __Construct(ITreeObject parent)
        {
            return new Page50000(parent);
        }

        public static Page50000 __Construct(ITreeObject parent, NavRecord record)
        {
            return new Page50000(parent, record);
        }

        private void SetAdminUserPremium(NavCode inputUserName)
        {
            using (SetAdminUserPremium_Scope_1114605834 \u03b2scope = new SetAdminUserPremium_Scope_1114605834(this, inputUserName))
                \u03b2scope.Run();
        }

        [NavName("SetAdminUserPremium")]
        [SourceSpans(21673607571505208L, 21955082548281410L, 22236553230090248L)]
        private class SetAdminUserPremium_Scope_1114605834 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("InputUserName")]
            public NavCode inputUserName;
            [NavName("User")]
            public INavRecordHandle user;
            protected override uint RawScopeId
            {
                get
                {
                    return SetAdminUserPremium_Scope_1114605834.\u03b1scopeId;
                }

                set
                {
                    SetAdminUserPremium_Scope_1114605834.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return SetAdminUserPremium_Scope_1114605834.\u03b3eventScope;
                }

                set
                {
                    SetAdminUserPremium_Scope_1114605834.\u03b3eventScope = value;
                }
            }

            internal SetAdminUserPremium_Scope_1114605834(Page50000 \u03b2parent, NavCode inputUserName): base (\u03b2parent)
            {
                this.inputUserName = inputUserName.ModifyLength(50);
                this.user = new NavRecordHandle(this, 2000000120, false, SecurityFiltering.Validated);
            }

            protected override void OnRun()
            {
                StmtHit(0);
                base.Parent.AssignPlanToUser(this.inputUserName, ALCompiler.StringToGuid(base.Parent.premiumPlanTxt));
                StmtHit(1);
                base.Parent.AssignPlanUserGroupsToUser(this.inputUserName, ALCompiler.StringToGuid(base.Parent.premiumPlanTxt));
            }
        }

        private bool GetUser([NavObjectId(ObjectId = 2000000120)][NavByReferenceAttribute] INavRecordHandle user, NavCode inputUserName)
        {
            using (GetUser_Scope__1394317518 \u03b2scope = new GetUser_Scope__1394317518(this, user, inputUserName))
            {
                \u03b2scope.Run();
                return \u03b2scope.\u03b3retVal;
            }
        }

        [NavName("GetUser")]
        [SourceSpans(62768954180829234L, 63050429157605405L, 63331899839414280L)]
        private class GetUser_Scope__1394317518 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("User")]
            public INavRecordHandle user;
            [NavName("InputUserName")]
            public NavCode inputUserName;
            [ReturnValue]
            public bool \u03b3retVal = default (bool);
            protected override uint RawScopeId
            {
                get
                {
                    return GetUser_Scope__1394317518.\u03b1scopeId;
                }

                set
                {
                    GetUser_Scope__1394317518.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return GetUser_Scope__1394317518.\u03b3eventScope;
                }

                set
                {
                    GetUser_Scope__1394317518.\u03b3eventScope = value;
                }
            }

            internal GetUser_Scope__1394317518(Page50000 \u03b2parent, [NavObjectId(ObjectId = 2000000120)][NavByReferenceAttribute] INavRecordHandle user, NavCode inputUserName): base (\u03b2parent)
            {
                this.user = user;
                this.inputUserName = inputUserName.ModifyLength(50);
            }

            protected override void OnRun()
            {
                StmtHit(0);
                this.user.Target.ALSetRangeSafe(2, NavType.Code, this.inputUserName);
                StmtHit(1);
                this.\u03b3retVal = this.user.Target.ALFindFirst(DataError.TrapError);
                return;
            }
        }

        private void CreateUser(NavCode inputUserName, NavText inputFullName, NavText inputPassword)
        {
            using (CreateUser_Scope_573225691 \u03b2scope = new CreateUser_Scope_573225691(this, inputUserName, inputFullName, inputPassword))
                \u03b2scope.Run();
        }

        [NavName("CreateUser")]
        [SourceSpans(30117869759692836L, 30399349031436305L, 30962281805119506L, 31243756781895726L, 31525231758671914L, 31806706735448106L, 32088181712224298L, 32369656689000512L, 32651131665776666L, 32932606642552896L, 33214081619329066L, 33495556596105256L, 33777031572881434L, 34058502254690312L)]
        private class CreateUser_Scope_573225691 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("InputUserName")]
            public NavCode inputUserName;
            [NavName("InputFullName")]
            public NavText inputFullName;
            [NavName("InputPassword")]
            public NavText inputPassword;
            [NavName("User")]
            public INavRecordHandle user;
            protected override uint RawScopeId
            {
                get
                {
                    return CreateUser_Scope_573225691.\u03b1scopeId;
                }

                set
                {
                    CreateUser_Scope_573225691.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return CreateUser_Scope_573225691.\u03b3eventScope;
                }

                set
                {
                    CreateUser_Scope_573225691.\u03b3eventScope = value;
                }
            }

            internal CreateUser_Scope_573225691(Page50000 \u03b2parent, NavCode inputUserName, NavText inputFullName, NavText inputPassword): base (\u03b2parent)
            {
                this.inputUserName = inputUserName.ModifyLength(50);
                this.inputFullName = inputFullName.ModifyLength(80);
                this.inputPassword = inputPassword.ModifyLength(80);
                this.user = new NavRecordHandle(this, 2000000120, false, SecurityFiltering.Validated);
            }

            protected override void OnRun()
            {
                if (CStmtHit(0) & (base.Parent.UserExists(this.inputUserName)))
                {
                    StmtHit(1);
                    return;
                }

                StmtHit(2);
                this.user.Target.ALInit();
                StmtHit(3);
                this.user.Target.SetFieldValueSafe(1, NavType.GUID, ALCompiler.ToNavValue(Guid.NewGuid()));
                StmtHit(4);
                this.user.Target.SetFieldValueSafe(2, NavType.Code, this.inputUserName);
                StmtHit(5);
                this.user.Target.SetFieldValueSafe(3, NavType.Text, this.inputFullName);
                StmtHit(6);
                this.user.Target.SetFieldValueSafe(4, NavType.Option, NavOption.Create(((NavOption)this.user.Target.GetFieldValueSafe(4, NavType.Option)).NavOptionMetadata, 0));
                StmtHit(7);
                this.user.Target.SetFieldValueSafe(10, NavType.Option, NavOption.Create(((NavOption)this.user.Target.GetFieldValueSafe(10, NavType.Option)).NavOptionMetadata, 0));
                StmtHit(8);
                this.user.Target.ALInsert(DataError.ThrowError, true);
                StmtHit(9);
                ALDatabase.ALSetUserPassword(DataError.ThrowError, this.user.Target.GetFieldValueSafe(1, NavType.GUID).ToGuid(), this.inputPassword);
                StmtHit(10);
                this.user.Target.ALGet(DataError.ThrowError, ALCompiler.ToNavValue(this.user.Target.GetFieldValueSafe(1, NavType.GUID).ToGuid()));
                StmtHit(11);
                this.user.Target.SetFieldValueSafe(8, NavType.Boolean, ALCompiler.ToNavValue(false));
                StmtHit(12);
                this.user.Target.ALModify(DataError.ThrowError, true);
            }
        }

        private void CreateTestUsers(NavText inputPassword)
        {
            using (CreateTestUsers_Scope__97050999 \u03b2scope = new CreateTestUsers_Scope__97050999(this, inputPassword))
                \u03b2scope.Run();
        }

        [NavName("CreateTestUsers")]
        [SourceSpans(23362457432162339L, 23643932408938523L, 23925407385714724L, 24206878067523592L)]
        private class CreateTestUsers_Scope__97050999 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("InputPassword")]
            public NavText inputPassword;
            protected override uint RawScopeId
            {
                get
                {
                    return CreateTestUsers_Scope__97050999.\u03b1scopeId;
                }

                set
                {
                    CreateTestUsers_Scope__97050999.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return CreateTestUsers_Scope__97050999.\u03b3eventScope;
                }

                set
                {
                    CreateTestUsers_Scope__97050999.\u03b3eventScope = value;
                }
            }

            internal CreateTestUsers_Scope__97050999(Page50000 \u03b2parent, NavText inputPassword): base (\u03b2parent)
            {
                this.inputPassword = inputPassword.ModifyLength(80);
            }

            protected override void OnRun()
            {
                StmtHit(0);
                base.Parent.CreateUsers(this.inputPassword);
                StmtHit(1);
                base.Parent.AssignPlansToUsers();
                StmtHit(2);
                base.Parent.AssignPlanUserGroupsToUsers();
            }
        }

        private void AssignPlanUserGroupsToUser(NavCode inputUserName, Guid inputPlanID)
        {
            using (AssignPlanUserGroupsToUser_Scope_1091438371 \u03b2scope = new AssignPlanUserGroupsToUser_Scope_1091438371(this, inputUserName, inputPlanID))
                \u03b2scope.Run();
        }

        [NavName("AssignPlanUserGroupsToUser")]
        [SourceSpans(51228493017907243L, 51509972289650705L, 52072917948235836L, 52354397219979281L, 53198822150307932L, 53480305717018660L, 53761750629023752L)]
        private class AssignPlanUserGroupsToUser_Scope_1091438371 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("InputUserName")]
            public NavCode inputUserName;
            [NavName("InputPlanID")]
            public Guid inputPlanID;
            [NavName("User")]
            public INavRecordHandle user;
            [NavName("UserGroupPlan")]
            public INavRecordHandle userGroupPlan;
            protected override uint RawScopeId
            {
                get
                {
                    return AssignPlanUserGroupsToUser_Scope_1091438371.\u03b1scopeId;
                }

                set
                {
                    AssignPlanUserGroupsToUser_Scope_1091438371.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return AssignPlanUserGroupsToUser_Scope_1091438371.\u03b3eventScope;
                }

                set
                {
                    AssignPlanUserGroupsToUser_Scope_1091438371.\u03b3eventScope = value;
                }
            }

            internal AssignPlanUserGroupsToUser_Scope_1091438371(Page50000 \u03b2parent, NavCode inputUserName, Guid inputPlanID): base (\u03b2parent)
            {
                this.inputUserName = inputUserName.ModifyLength(50);
                this.inputPlanID = inputPlanID;
                this.user = new NavRecordHandle(this, 2000000120, false, SecurityFiltering.Validated);
                this.userGroupPlan = new NavRecordHandle(this, 9007, false, SecurityFiltering.Validated);
            }

            protected override void OnRun()
            {
                if (CStmtHit(0) & (!base.Parent.GetUser(this.user, this.inputUserName)))
                {
                    StmtHit(1);
                    return;
                }

                if (CStmtHit(2) & (!base.Parent.GetPlanUserGroups(this.userGroupPlan, this.inputPlanID)))
                {
                    StmtHit(3);
                    return;
                }

                do
                {
                    StmtHit(4);
                    base.Parent.AssignUserGroupToUser(((NavCode)this.userGroupPlan.Target.GetFieldValueSafe(2, NavType.Code)), this.user.Target.GetFieldValueSafe(1, NavType.GUID).ToGuid());
                }
                while (!(CStmtHit(5) & (this.userGroupPlan.Target.ALNext() == 0)));
            }
        }

        private void AssignUserGroupToUser(NavCode inputUserGroupCode, Guid inputUserSecurityID)
        {
            using (AssignUserGroupToUser_Scope__155750982 \u03b2scope = new AssignUserGroupToUser_Scope__155750982(this, inputUserGroupCode, inputUserSecurityID))
                \u03b2scope.Run();
        }

        [NavName("AssignUserGroupToUser")]
        [SourceSpans(55450617669550157L, 55732096941293585L, 56295029714976797L, 56576504691753024L, 56857979668529218L, 57139454645305381L, 57420925327114248L)]
        private class AssignUserGroupToUser_Scope__155750982 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("InputUserGroupCode")]
            public NavCode inputUserGroupCode;
            [NavName("InputUserSecurityID")]
            public Guid inputUserSecurityID;
            [NavName("UserGroupMember")]
            public INavRecordHandle userGroupMember;
            protected override uint RawScopeId
            {
                get
                {
                    return AssignUserGroupToUser_Scope__155750982.\u03b1scopeId;
                }

                set
                {
                    AssignUserGroupToUser_Scope__155750982.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return AssignUserGroupToUser_Scope__155750982.\u03b3eventScope;
                }

                set
                {
                    AssignUserGroupToUser_Scope__155750982.\u03b3eventScope = value;
                }
            }

            internal AssignUserGroupToUser_Scope__155750982(Page50000 \u03b2parent, NavCode inputUserGroupCode, Guid inputUserSecurityID): base (\u03b2parent)
            {
                this.inputUserGroupCode = inputUserGroupCode.ModifyLength(20);
                this.inputUserSecurityID = inputUserSecurityID;
                this.userGroupMember = new NavRecordHandle(this, 9001, false, SecurityFiltering.Validated);
            }

            protected override void OnRun()
            {
                if (CStmtHit(0) & (base.Parent.UserGroupIsAssignedToUser(this.inputUserGroupCode, this.inputUserSecurityID)))
                {
                    StmtHit(1);
                    return;
                }

                StmtHit(2);
                this.userGroupMember.Target.ALInit();
                StmtHit(3);
                this.userGroupMember.Target.SetFieldValueSafe(1, NavType.Code, this.inputUserGroupCode);
                StmtHit(4);
                this.userGroupMember.Target.SetFieldValueSafe(2, NavType.GUID, ALCompiler.ToNavValue(this.inputUserSecurityID));
                StmtHit(5);
                this.userGroupMember.Target.ALInsert(DataError.ThrowError, true);
            }
        }

        private void AssignPlansToUsers()
        {
            using (AssignPlansToUsers_Scope_428121996 \u03b2scope = new AssignPlansToUsers_Scope_428121996(this))
                \u03b2scope.Run();
        }

        [NavName("AssignPlansToUsers")]
        [SourceSpans(37436206270971979L, 37717681247748169L, 37999156224524349L, 38280631201300545L, 38562106178076739L, 38843581154852947L, 39125051836661768L)]
        private class AssignPlansToUsers_Scope_428121996 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            protected override uint RawScopeId
            {
                get
                {
                    return AssignPlansToUsers_Scope_428121996.\u03b1scopeId;
                }

                set
                {
                    AssignPlansToUsers_Scope_428121996.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return AssignPlansToUsers_Scope_428121996.\u03b3eventScope;
                }

                set
                {
                    AssignPlansToUsers_Scope_428121996.\u03b3eventScope = value;
                }
            }

            internal AssignPlansToUsers_Scope_428121996(Page50000 \u03b2parent): base (\u03b2parent)
            {
            }

            protected override void OnRun()
            {
                StmtHit(0);
                base.Parent.AssignPlanToUser(new NavCode(50, base.Parent.delegatedAdminUserNameTok), ALCompiler.StringToGuid(base.Parent.delegatedAdminPlanTxt));
                StmtHit(1);
                base.Parent.AssignPlanToUser(new NavCode(50, base.Parent.internalAdminUserNameTok), ALCompiler.StringToGuid(base.Parent.internalAdminPlanTxt));
                StmtHit(2);
                base.Parent.AssignPlanToUser(new NavCode(50, base.Parent.premiumUserNameTok), ALCompiler.StringToGuid(base.Parent.premiumPlanTxt));
                StmtHit(3);
                base.Parent.AssignPlanToUser(new NavCode(50, base.Parent.essentialUserNameTok), ALCompiler.StringToGuid(base.Parent.essentialPlanTxt));
                StmtHit(4);
                base.Parent.AssignPlanToUser(new NavCode(50, base.Parent.teamMemberUserNameTok), ALCompiler.StringToGuid(base.Parent.teamMemberPlanTxt));
                StmtHit(5);
                base.Parent.AssignPlanToUser(new NavCode(50, base.Parent.externalAccountantUserNameTok), ALCompiler.StringToGuid(base.Parent.externalAccountantPlanTxt));
            }
        }

        private void AssignPlanToUser(NavCode inputUserName, Guid inputPlanID)
        {
            using (AssignPlanToUser_Scope_1459091283 \u03b2scope = new AssignPlanToUser_Scope_1459091283(this, inputUserName, inputPlanID))
                \u03b2scope.Run();
        }

        [NavName("AssignPlanToUser")]
        [SourceSpans(41095393853964331L, 41376873125707793L, 41939818784292933L, 42221298056036369L, 42784230829719574L, 43065705806495807L, 43347180783271978L, 43628655760048158L, 43910126441857032L)]
        private class AssignPlanToUser_Scope_1459091283 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("InputUserName")]
            public NavCode inputUserName;
            [NavName("InputPlanID")]
            public Guid inputPlanID;
            [NavName("User")]
            public INavRecordHandle user;
            [NavName("UserPlan")]
            public INavRecordHandle userPlan;
            protected override uint RawScopeId
            {
                get
                {
                    return AssignPlanToUser_Scope_1459091283.\u03b1scopeId;
                }

                set
                {
                    AssignPlanToUser_Scope_1459091283.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return AssignPlanToUser_Scope_1459091283.\u03b3eventScope;
                }

                set
                {
                    AssignPlanToUser_Scope_1459091283.\u03b3eventScope = value;
                }
            }

            internal AssignPlanToUser_Scope_1459091283(Page50000 \u03b2parent, NavCode inputUserName, Guid inputPlanID): base (\u03b2parent)
            {
                this.inputUserName = inputUserName.ModifyLength(50);
                this.inputPlanID = inputPlanID;
                this.user = new NavRecordHandle(this, 2000000120, false, SecurityFiltering.Validated);
                this.userPlan = new NavRecordHandle(this, 9005, false, SecurityFiltering.Validated);
            }

            protected override void OnRun()
            {
                if (CStmtHit(0) & (!base.Parent.GetUser(this.user, this.inputUserName)))
                {
                    StmtHit(1);
                    return;
                }

                if (CStmtHit(2) & (base.Parent.PlanIsAssignedToUser(this.user.Target.GetFieldValueSafe(1, NavType.GUID).ToGuid(), this.inputPlanID)))
                {
                    StmtHit(3);
                    return;
                }

                StmtHit(4);
                this.userPlan.Target.ALInit();
                StmtHit(5);
                this.userPlan.Target.SetFieldValueSafe(1, NavType.GUID, ALCompiler.ToNavValue(this.user.Target.GetFieldValueSafe(1, NavType.GUID).ToGuid()));
                StmtHit(6);
                this.userPlan.Target.SetFieldValueSafe(2, NavType.GUID, ALCompiler.ToNavValue(this.inputPlanID));
                StmtHit(7);
                this.userPlan.Target.ALInsert(DataError.ThrowError, true);
            }
        }

        private bool GetPlanUserGroups([NavObjectId(ObjectId = 9007)][NavByReferenceAttribute] INavRecordHandle userGroupPlan, Guid inputPlanID)
        {
            using (GetPlanUserGroups_Scope_982833263 \u03b2scope = new GetPlanUserGroups_Scope_982833263(this, userGroupPlan, inputPlanID))
            {
                \u03b2scope.Run();
                return \u03b2scope.\u03b3retVal;
            }
        }

        [NavName("GetPlanUserGroups")]
        [SourceSpans(61080104320172087L, 61361579296948260L, 61643049978757128L)]
        private class GetPlanUserGroups_Scope_982833263 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("UserGroupPlan")]
            public INavRecordHandle userGroupPlan;
            [NavName("InputPlanID")]
            public Guid inputPlanID;
            [ReturnValue]
            public bool \u03b3retVal = default (bool);
            protected override uint RawScopeId
            {
                get
                {
                    return GetPlanUserGroups_Scope_982833263.\u03b1scopeId;
                }

                set
                {
                    GetPlanUserGroups_Scope_982833263.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return GetPlanUserGroups_Scope_982833263.\u03b3eventScope;
                }

                set
                {
                    GetPlanUserGroups_Scope_982833263.\u03b3eventScope = value;
                }
            }

            internal GetPlanUserGroups_Scope_982833263(Page50000 \u03b2parent, [NavObjectId(ObjectId = 9007)][NavByReferenceAttribute] INavRecordHandle userGroupPlan, Guid inputPlanID): base (\u03b2parent)
            {
                this.userGroupPlan = userGroupPlan;
                this.inputPlanID = inputPlanID;
            }

            protected override void OnRun()
            {
                StmtHit(0);
                this.userGroupPlan.Target.ALSetRangeSafe(1, NavType.GUID, ALCompiler.ToNavValue(this.inputPlanID));
                StmtHit(1);
                this.\u03b3retVal = this.userGroupPlan.Target.ALFindSet(DataError.TrapError);
                return;
            }
        }

        private void AddMySuperUser()
        {
            using (AddMySuperUser_Scope__709985791 \u03b2scope = new AddMySuperUser_Scope__709985791(this))
                \u03b2scope.Run();
        }

        [NavName("AddMySuperUser")]
        [SourceSpans(25332782269595708L, 25614252951404552L)]
        private class AddMySuperUser_Scope__709985791 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            protected override uint RawScopeId
            {
                get
                {
                    return AddMySuperUser_Scope__709985791.\u03b1scopeId;
                }

                set
                {
                    AddMySuperUser_Scope__709985791.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return AddMySuperUser_Scope__709985791.\u03b3eventScope;
                }

                set
                {
                    AddMySuperUser_Scope__709985791.\u03b3eventScope = value;
                }
            }

            internal AddMySuperUser_Scope__709985791(Page50000 \u03b2parent): base (\u03b2parent)
            {
            }

            protected override void OnRun()
            {
                StmtHit(0);
                NavCodeunit.RunCodeunit(DataError.ThrowError, 9000);
            }
        }

        private void AssignPlanUserGroupsToUsers()
        {
            using (AssignPlanUserGroupsToUsers_Scope__1118628142 \u03b2scope = new AssignPlanUserGroupsToUsers_Scope__1118628142(this))
                \u03b2scope.Run();
        }

        [NavName("AssignPlanUserGroupsToUsers")]
        [SourceSpans(47569305434914901L, 47850780411691091L, 48132255388467271L, 48413730365243467L, 48695205342019661L, 48976680318795869L, 49258151000604680L)]
        private class AssignPlanUserGroupsToUsers_Scope__1118628142 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            protected override uint RawScopeId
            {
                get
                {
                    return AssignPlanUserGroupsToUsers_Scope__1118628142.\u03b1scopeId;
                }

                set
                {
                    AssignPlanUserGroupsToUsers_Scope__1118628142.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return AssignPlanUserGroupsToUsers_Scope__1118628142.\u03b3eventScope;
                }

                set
                {
                    AssignPlanUserGroupsToUsers_Scope__1118628142.\u03b3eventScope = value;
                }
            }

            internal AssignPlanUserGroupsToUsers_Scope__1118628142(Page50000 \u03b2parent): base (\u03b2parent)
            {
            }

            protected override void OnRun()
            {
                StmtHit(0);
                base.Parent.AssignPlanUserGroupsToUser(new NavCode(50, base.Parent.delegatedAdminUserNameTok), ALCompiler.StringToGuid(base.Parent.delegatedAdminPlanTxt));
                StmtHit(1);
                base.Parent.AssignPlanUserGroupsToUser(new NavCode(50, base.Parent.internalAdminUserNameTok), ALCompiler.StringToGuid(base.Parent.internalAdminPlanTxt));
                StmtHit(2);
                base.Parent.AssignPlanUserGroupsToUser(new NavCode(50, base.Parent.premiumUserNameTok), ALCompiler.StringToGuid(base.Parent.premiumPlanTxt));
                StmtHit(3);
                base.Parent.AssignPlanUserGroupsToUser(new NavCode(50, base.Parent.essentialUserNameTok), ALCompiler.StringToGuid(base.Parent.essentialPlanTxt));
                StmtHit(4);
                base.Parent.AssignPlanUserGroupsToUser(new NavCode(50, base.Parent.teamMemberUserNameTok), ALCompiler.StringToGuid(base.Parent.teamMemberPlanTxt));
                StmtHit(5);
                base.Parent.AssignPlanUserGroupsToUser(new NavCode(50, base.Parent.externalAccountantUserNameTok), ALCompiler.StringToGuid(base.Parent.externalAccountantPlanTxt));
            }
        }

        private bool PlanIsAssignedToUser(Guid inputUserSecurityID, Guid inputPlanID)
        {
            using (PlanIsAssignedToUser_Scope__2124136378 \u03b2scope = new PlanIsAssignedToUser_Scope__2124136378(this, inputUserSecurityID, inputPlanID))
            {
                \u03b2scope.Run();
                return \u03b2scope.\u03b3retVal;
            }
        }

        [NavName("PlanIsAssignedToUser")]
        [SourceSpans(45598980597481539L, 45880455574257714L, 46161930551033891L, 46443401232842760L)]
        private class PlanIsAssignedToUser_Scope__2124136378 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("InputUserSecurityID")]
            public Guid inputUserSecurityID;
            [NavName("InputPlanID")]
            public Guid inputPlanID;
            [ReturnValue]
            public bool \u03b3retVal = default (bool);
            [NavName("UserPlan")]
            public INavRecordHandle userPlan;
            protected override uint RawScopeId
            {
                get
                {
                    return PlanIsAssignedToUser_Scope__2124136378.\u03b1scopeId;
                }

                set
                {
                    PlanIsAssignedToUser_Scope__2124136378.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return PlanIsAssignedToUser_Scope__2124136378.\u03b3eventScope;
                }

                set
                {
                    PlanIsAssignedToUser_Scope__2124136378.\u03b3eventScope = value;
                }
            }

            internal PlanIsAssignedToUser_Scope__2124136378(Page50000 \u03b2parent, Guid inputUserSecurityID, Guid inputPlanID): base (\u03b2parent)
            {
                this.inputUserSecurityID = inputUserSecurityID;
                this.inputPlanID = inputPlanID;
                this.userPlan = new NavRecordHandle(this, 9005, false, SecurityFiltering.Validated);
            }

            protected override void OnRun()
            {
                StmtHit(0);
                this.userPlan.Target.ALSetRangeSafe(1, NavType.GUID, ALCompiler.ToNavValue(this.inputUserSecurityID));
                StmtHit(1);
                this.userPlan.Target.ALSetRangeSafe(2, NavType.GUID, ALCompiler.ToNavValue(this.inputPlanID));
                StmtHit(2);
                this.\u03b3retVal = !this.userPlan.Target.ALIsEmpty;
                return;
            }
        }

        private void CreateUsers(NavText inputPassword)
        {
            using (CreateUsers_Scope__1730182917 \u03b2scope = new CreateUsers_Scope__1730182917(this, inputPassword))
                \u03b2scope.Run();
        }

        [NavName("CreateUsers")]
        [SourceSpans(26740157153476696L, 27021632130252886L, 27303107107029066L, 27584582083805262L, 27866057060581456L, 28147532037357664L, 28429002719166472L)]
        private class CreateUsers_Scope__1730182917 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("InputPassword")]
            public NavText inputPassword;
            protected override uint RawScopeId
            {
                get
                {
                    return CreateUsers_Scope__1730182917.\u03b1scopeId;
                }

                set
                {
                    CreateUsers_Scope__1730182917.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return CreateUsers_Scope__1730182917.\u03b3eventScope;
                }

                set
                {
                    CreateUsers_Scope__1730182917.\u03b3eventScope = value;
                }
            }

            internal CreateUsers_Scope__1730182917(Page50000 \u03b2parent, NavText inputPassword): base (\u03b2parent)
            {
                this.inputPassword = inputPassword.ModifyLength(80);
            }

            protected override void OnRun()
            {
                StmtHit(0);
                base.Parent.CreateUser(new NavCode(50, base.Parent.delegatedAdminUserNameTok), new NavText(80, base.Parent.delegatedAdminFullNameTxt), this.inputPassword);
                StmtHit(1);
                base.Parent.CreateUser(new NavCode(50, base.Parent.internalAdminUserNameTok), new NavText(80, base.Parent.internalAdminFullNameTxt), this.inputPassword);
                StmtHit(2);
                base.Parent.CreateUser(new NavCode(50, base.Parent.premiumUserNameTok), new NavText(80, base.Parent.premiumFullNameTxt), this.inputPassword);
                StmtHit(3);
                base.Parent.CreateUser(new NavCode(50, base.Parent.essentialUserNameTok), new NavText(80, base.Parent.essentialFullNameTxt), this.inputPassword);
                StmtHit(4);
                base.Parent.CreateUser(new NavCode(50, base.Parent.teamMemberUserNameTok), new NavText(80, base.Parent.teamMemberFullNameTxt), this.inputPassword);
                StmtHit(5);
                base.Parent.CreateUser(new NavCode(50, base.Parent.externalAccountantUserNameTok), new NavText(80, base.Parent.externalAccountantFullNameTxt), this.inputPassword);
            }
        }

        private bool UserGroupIsAssignedToUser(NavCode inputUserGroupCode, Guid inputUserSecurityID)
        {
            using (UserGroupIsAssignedToUser_Scope__1976391198 \u03b2scope = new UserGroupIsAssignedToUser_Scope__1976391198(this, inputUserGroupCode, inputUserSecurityID))
            {
                \u03b2scope.Run();
                return \u03b2scope.\u03b3retVal;
            }
        }

        [NavName("UserGroupIsAssignedToUser")]
        [SourceSpans(59109779482738760L, 59391254459514954L, 59672729436291114L, 59954200118099976L)]
        private class UserGroupIsAssignedToUser_Scope__1976391198 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("InputUserGroupCode")]
            public NavCode inputUserGroupCode;
            [NavName("InputUserSecurityID")]
            public Guid inputUserSecurityID;
            [ReturnValue]
            public bool \u03b3retVal = default (bool);
            [NavName("UserGroupMember")]
            public INavRecordHandle userGroupMember;
            protected override uint RawScopeId
            {
                get
                {
                    return UserGroupIsAssignedToUser_Scope__1976391198.\u03b1scopeId;
                }

                set
                {
                    UserGroupIsAssignedToUser_Scope__1976391198.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return UserGroupIsAssignedToUser_Scope__1976391198.\u03b3eventScope;
                }

                set
                {
                    UserGroupIsAssignedToUser_Scope__1976391198.\u03b3eventScope = value;
                }
            }

            internal UserGroupIsAssignedToUser_Scope__1976391198(Page50000 \u03b2parent, NavCode inputUserGroupCode, Guid inputUserSecurityID): base (\u03b2parent)
            {
                this.inputUserGroupCode = inputUserGroupCode.ModifyLength(20);
                this.inputUserSecurityID = inputUserSecurityID;
                this.userGroupMember = new NavRecordHandle(this, 9001, false, SecurityFiltering.Validated);
            }

            protected override void OnRun()
            {
                StmtHit(0);
                this.userGroupMember.Target.ALSetRangeSafe(1, NavType.Code, this.inputUserGroupCode);
                StmtHit(1);
                this.userGroupMember.Target.ALSetRangeSafe(2, NavType.GUID, ALCompiler.ToNavValue(this.inputUserSecurityID));
                StmtHit(2);
                this.\u03b3retVal = !this.userGroupMember.Target.ALIsEmpty;
                return;
            }
        }

        protected override bool OnInsertRecord(bool belowxRec)
        {
            using (OnInsertRecord_Scope \u03b2scope = new OnInsertRecord_Scope(this, belowxRec))
            {
                \u03b2scope.Run();
                return \u03b2scope.\u03b3retVal;
            }
        }

        [SourceSpans(12947900471509012L, 13510884784603173L, 11822000564404244L, 12384984877498415L, 10696100657299476L, 11259084970393643L, 14355253880356872L)]
        private class OnInsertRecord_Scope : NavTriggerMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("BelowxRec")]
            public bool belowxRec;
            [ReturnValue]
            public bool \u03b3retVal = true;
            protected override uint RawScopeId
            {
                get
                {
                    return OnInsertRecord_Scope.\u03b1scopeId;
                }

                set
                {
                    OnInsertRecord_Scope.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return OnInsertRecord_Scope.\u03b3eventScope;
                }

                set
                {
                    OnInsertRecord_Scope.\u03b3eventScope = value;
                }
            }

            internal OnInsertRecord_Scope(Page50000 \u03b2parent, bool belowxRec): base (\u03b2parent)
            {
                this.belowxRec = belowxRec;
            }

            protected override void OnRun()
            {
                NavText @tmp0 = ((NavText)base.Parent.Rec.GetFieldValueSafe(2, NavType.Text));
                if (CStmtHit(4) & ((@tmp0.CompareTo(new NavText(250, "CreateTestUsers")) == 0)))
                {
                    StmtHit(5);
                    base.Parent.CreateTestUsers(new NavText(80, ((NavText)base.Parent.Rec.GetFieldValueSafe(3, NavType.Text))));
                }
                else if (CStmtHit(2) & ((@tmp0.CompareTo(new NavText(250, "SetAdminUserPremium")) == 0)))
                {
                    StmtHit(3);
                    base.Parent.SetAdminUserPremium(new NavCode(50, ((NavText)base.Parent.Rec.GetFieldValueSafe(3, NavType.Text))));
                }
                else if (CStmtHit(0) & ((@tmp0.CompareTo(new NavText(250, "AddMySuperUser")) == 0)))
                {
                    StmtHit(1);
                    base.Parent.AddMySuperUser();
                }
            }
        }

        private bool UserExists(NavCode inputUserName)
        {
            using (UserExists_Scope_1406591717 \u03b2scope = new UserExists_Scope_1406591717(this, inputUserName))
            {
                \u03b2scope.Run();
                return \u03b2scope.\u03b3retVal;
            }
        }

        [NavName("UserExists")]
        [SourceSpans(35747356410314802L, 36028831387090975L, 36310302068899848L)]
        private class UserExists_Scope_1406591717 : NavMethodScope<Page50000>
        {
            public static uint \u03b1scopeId;
            public static NavEventScope \u03b3eventScope;
            [NavName("InputUserName")]
            public NavCode inputUserName;
            [ReturnValue]
            public bool \u03b3retVal = default (bool);
            [NavName("User")]
            public INavRecordHandle user;
            protected override uint RawScopeId
            {
                get
                {
                    return UserExists_Scope_1406591717.\u03b1scopeId;
                }

                set
                {
                    UserExists_Scope_1406591717.\u03b1scopeId = value;
                }
            }

            public override NavEventScope EventScope
            {
                get
                {
                    return UserExists_Scope_1406591717.\u03b3eventScope;
                }

                set
                {
                    UserExists_Scope_1406591717.\u03b3eventScope = value;
                }
            }

            internal UserExists_Scope_1406591717(Page50000 \u03b2parent, NavCode inputUserName): base (\u03b2parent)
            {
                this.inputUserName = inputUserName.ModifyLength(50);
                this.user = new NavRecordHandle(this, 2000000120, false, SecurityFiltering.Validated);
            }

            protected override void OnRun()
            {
                StmtHit(0);
                this.user.Target.ALSetRangeSafe(2, NavType.Code, this.inputUserName);
                StmtHit(1);
                this.\u03b3retVal = !this.user.Target.ALIsEmpty;
                return;
            }
        }
    }
}