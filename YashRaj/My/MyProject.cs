using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh.My
{
    [StandardModule]
    [HideModuleName]
    [GeneratedCode("MyTemplate", "8.0.0.0")]
    internal sealed class MyProject
    {
        //// Token: 0x17000001 RID: 1
        //// (get) Token: 0x06000006 RID: 6 RVA: 0x002764F8 File Offset: 0x002748F8
        //[HelpKeyword("My.Computer")]
        //internal static MyComputer Computer
        //{
        //	[DebuggerHidden]
        //	get
        //	{
        //		return MyProject.m_ComputerObjectProvider.GetInstance;
        //	}
        //}

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x06000007 RID: 7 RVA: 0x00276510 File Offset: 0x00274910
        [HelpKeyword("My.Application")]
        internal static MyApplication Application
        {
            //[DebuggerHidden]
            get
            {
                return MyProject.m_AppObjectProvider.GetInstance;
            }
        }

        // Token: 0x17000003 RID: 3
        // (get) Token: 0x06000008 RID: 8 RVA: 0x00276528 File Offset: 0x00274928
        [HelpKeyword("My.User")]
        internal static User User
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_UserObjectProvider.GetInstance;
            }
        }

        // Token: 0x17000004 RID: 4
        // (get) Token: 0x06000009 RID: 9 RVA: 0x00276540 File Offset: 0x00274940
        [HelpKeyword("My.Forms")]
        internal static MyProject.MyForms Forms
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_MyFormsObjectProvider.GetInstance;
            }
        }

        // Token: 0x17000005 RID: 5
        // (get) Token: 0x0600000A RID: 10 RVA: 0x00276558 File Offset: 0x00274958
        [HelpKeyword("My.WebServices")]
        internal static MyProject.MyWebServices WebServices
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_MyWebServicesObjectProvider.GetInstance;
            }
        }

        //// Token: 0x04000001 RID: 1
        private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

        // Token: 0x04000002 RID: 2
        private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

        // Token: 0x04000003 RID: 3
        private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

        // Token: 0x04000004 RID: 4
        private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

        // Token: 0x04000005 RID: 5
        private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

        // Token: 0x02000005 RID: 5
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
        internal sealed class MyForms
        {
            // Token: 0x17000006 RID: 6
            // (get) Token: 0x0600000B RID: 11 RVA: 0x00276570 File Offset: 0x00274970
            // (set) Token: 0x0600004D RID: 77 RVA: 0x00276EB8 File Offset: 0x002752B8
            public Agent_abntie Agent_abntie
            {
                get
                {
                    this.m_Agent_abntie = MyProject.MyForms.Create__Instance__<Agent_abntie>(this.m_Agent_abntie);
                    return this.m_Agent_abntie;
                }
                set
                {
                    if (value == this.m_Agent_abntie)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Agent_abntie>(ref this.m_Agent_abntie);
                }
            }

            // Token: 0x17000007 RID: 7
            // (get) Token: 0x0600000C RID: 12 RVA: 0x00276594 File Offset: 0x00274994
            // (set) Token: 0x0600004E RID: 78 RVA: 0x00276EE0 File Offset: 0x002752E0
            public Agent_CUP Agent_CUP
            {
                get
                {
                    this.m_Agent_CUP = MyProject.MyForms.Create__Instance__<Agent_CUP>(this.m_Agent_CUP);
                    return this.m_Agent_CUP;
                }
                set
                {
                    if (value == this.m_Agent_CUP)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Agent_CUP>(ref this.m_Agent_CUP);
                }
            }

            // Token: 0x17000008 RID: 8
            // (get) Token: 0x0600000D RID: 13 RVA: 0x002765B8 File Offset: 0x002749B8
            // (set) Token: 0x0600004F RID: 79 RVA: 0x00276F08 File Offset: 0x00275308
            public Agent_match Agent_match
            {
                get
                {
                    this.m_Agent_match = MyProject.MyForms.Create__Instance__<Agent_match>(this.m_Agent_match);
                    return this.m_Agent_match;
                }
                set
                {
                    if (value == this.m_Agent_match)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Agent_match>(ref this.m_Agent_match);
                }
            }

            // Token: 0x17000008 RID: 8
            // (get) Token: 0x0600000D RID: 13 RVA: 0x002765B8 File Offset: 0x002749B8
            // (set) Token: 0x0600004F RID: 79 RVA: 0x00276F08 File Offset: 0x00275308
            public Agent_Connect Agent_Connect
            {
                get
                {
                    this.m_Agent_Connect = MyProject.MyForms.Create__Instance__<Agent_Connect>(this.m_Agent_Connect);
                    return this.m_Agent_Connect;
                }
                set
                {
                    if (value == this.m_Agent_Connect)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Agent_Connect>(ref this.m_Agent_Connect);
                }
            }

            //// Token: 0x17000009 RID: 9
            //// (get) Token: 0x0600000E RID: 14 RVA: 0x002765DC File Offset: 0x002749DC
            //// (set) Token: 0x06000050 RID: 80 RVA: 0x00276F30 File Offset: 0x00275330
            //public All_Session All_Session
            //{
            //    get
            //    {
            //        this.m_All_Session = MyProject.MyForms.Create__Instance__<All_Session>(this.m_All_Session);
            //        return this.m_All_Session;
            //    }
            //    set
            //    {
            //        if (value == this.m_All_Session)
            //        {
            //            return;
            //        }
            //        if (value != null)
            //        {
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        }
            //        this.Dispose__Instance__<All_Session>(ref this.m_All_Session);
            //    }
            //}

            // Token: 0x1700000A RID: 10
            // (get) Token: 0x0600000F RID: 15 RVA: 0x00276600 File Offset: 0x00274A00
            // (set) Token: 0x06000051 RID: 81 RVA: 0x00276F58 File Offset: 0x00275358
            public Balance_Message Balance_Message
            {
                get
                {
                    this.m_Balance_Message = MyProject.MyForms.Create__Instance__<Balance_Message>(this.m_Balance_Message);
                    return this.m_Balance_Message;
                }
                set
                {
                    if (value == this.m_Balance_Message)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Balance_Message>(ref this.m_Balance_Message);
                }
            }

            // Token: 0x1700000B RID: 11
            // (get) Token: 0x06000010 RID: 16 RVA: 0x00276624 File Offset: 0x00274A24
            // (set) Token: 0x06000052 RID: 82 RVA: 0x00276F80 File Offset: 0x00275380
            //public Bit Bit
            //{
            //	get
            //	{
            //		this.m_Bit = MyProject.MyForms.Create__Instance__<Bit>(this.m_Bit);
            //		return this.m_Bit;
            //	}
            //	set
            //	{
            //		if (value == this.m_Bit)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<Bit>(ref this.m_Bit);
            //	}
            //}

            // Token: 0x1700000C RID: 12
            // (get) Token: 0x06000011 RID: 17 RVA: 0x00276648 File Offset: 0x00274A48
            // (set) Token: 0x06000053 RID: 83 RVA: 0x00276FA8 File Offset: 0x002753A8
            //public Boolk_MSG Boolk_MSG
            //{
            //	get
            //	{
            //		this.m_Boolk_MSG = MyProject.MyForms.Create__Instance__<Boolk_MSG>(this.m_Boolk_MSG);
            //		return this.m_Boolk_MSG;
            //	}
            //	set
            //	{
            //		if (value == this.m_Boolk_MSG)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<Boolk_MSG>(ref this.m_Boolk_MSG);
            //	}
            //}

            // Token: 0x1700000D RID: 13
            // (get) Token: 0x06000012 RID: 18 RVA: 0x0027666C File Offset: 0x00274A6C
            // (set) Token: 0x06000054 RID: 84 RVA: 0x00276FD0 File Offset: 0x002753D0
            public CUP CUP
            {
                get
                {
                    this.m_CUP = MyProject.MyForms.Create__Instance__<CUP>(this.m_CUP);
                    return this.m_CUP;
                }
                set
                {
                    if (value == this.m_CUP)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<CUP>(ref this.m_CUP);
                }
            }

            // Token: 0x1700000E RID: 14
            // (get) Token: 0x06000013 RID: 19 RVA: 0x00276690 File Offset: 0x00274A90
            // (set) Token: 0x06000055 RID: 85 RVA: 0x00276FF8 File Offset: 0x002753F8
            public Cup_match_Book Cup_match_Book
            {
                get
                {
                    this.m_Cup_match_Book = MyProject.MyForms.Create__Instance__<Cup_match_Book>(this.m_Cup_match_Book);
                    return this.m_Cup_match_Book;
                }
                set
                {
                    if (value == this.m_Cup_match_Book)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Cup_match_Book>(ref this.m_Cup_match_Book);
                }
            }

            //// Token: 0x1700000F RID: 15
            //// (get) Token: 0x06000014 RID: 20 RVA: 0x002766B4 File Offset: 0x00274AB4
            //// (set) Token: 0x06000056 RID: 86 RVA: 0x00277020 File Offset: 0x00275420
            //public Cup_Modify Cup_Modify
            //{
            //    get
            //    {
            //        this.m_Cup_Modify = MyProject.MyForms.Create__Instance__<Cup_Modify>(this.m_Cup_Modify);
            //        return this.m_Cup_Modify;
            //    }
            //    set
            //    {
            //        if (value == this.m_Cup_Modify)
            //        {
            //            return;
            //        }
            //        if (value != null)
            //        {
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        }
            //        this.Dispose__Instance__<Cup_Modify>(ref this.m_Cup_Modify);
            //    }
            //}

            // Token: 0x17000010 RID: 16
            // (get) Token: 0x06000015 RID: 21 RVA: 0x002766D8 File Offset: 0x00274AD8
            // (set) Token: 0x06000057 RID: 87 RVA: 0x00277048 File Offset: 0x00275448
            public Cup_Report Cup_Report
            {
                get
                {
                    this.m_Cup_Report = MyProject.MyForms.Create__Instance__<Cup_Report>(this.m_Cup_Report);
                    return this.m_Cup_Report;
                }
                set
                {
                    if (value == this.m_Cup_Report)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Cup_Report>(ref this.m_Cup_Report);
                }
            }

            // Token: 0x17000011 RID: 17
            // (get) Token: 0x06000016 RID: 22 RVA: 0x002766FC File Offset: 0x00274AFC
            // (set) Token: 0x06000058 RID: 88 RVA: 0x00277070 File Offset: 0x00275470
            public Declear_New_Sesstions Declear_New_Sesstions
            {
                get
                {
                    this.m_Declear_New_Sesstions = MyProject.MyForms.Create__Instance__<Declear_New_Sesstions>(this.m_Declear_New_Sesstions);
                    return this.m_Declear_New_Sesstions;
                }
                set
                {
                    if (value == this.m_Declear_New_Sesstions)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Declear_New_Sesstions>(ref this.m_Declear_New_Sesstions);
                }
            }

            // Token: 0x17000012 RID: 18
            // (get) Token: 0x06000017 RID: 23 RVA: 0x00276720 File Offset: 0x00274B20
            // (set) Token: 0x06000059 RID: 89 RVA: 0x00277098 File Offset: 0x00275498
            //public Dialog1 Dialog1
            //{
            //	get
            //	{
            //		this.m_Dialog1 = MyProject.MyForms.Create__Instance__<Dialog1>(this.m_Dialog1);
            //		return this.m_Dialog1;
            //	}
            //	set
            //	{
            //		if (value == this.m_Dialog1)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<Dialog1>(ref this.m_Dialog1);
            //	}
            //}

            // Token: 0x17000013 RID: 19
            // (get) Token: 0x06000018 RID: 24 RVA: 0x00276744 File Offset: 0x00274B44
            // (set) Token: 0x0600005A RID: 90 RVA: 0x002770C0 File Offset: 0x002754C0
            public Dialog_PriDATA Dialog_PriDATA
            {
                get
                {
                    this.m_Dialog_PriDATA = MyProject.MyForms.Create__Instance__<Dialog_PriDATA>(this.m_Dialog_PriDATA);
                    return this.m_Dialog_PriDATA;
                }
                set
                {
                    if (value == this.m_Dialog_PriDATA)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Dialog_PriDATA>(ref this.m_Dialog_PriDATA);
                }
            }

            // Token: 0x17000014 RID: 20
            // (get) Token: 0x06000019 RID: 25 RVA: 0x00276768 File Offset: 0x00274B68
            // (set) Token: 0x0600005B RID: 91 RVA: 0x002770E8 File Offset: 0x002754E8
            public DPP_AbnTie DPP_AbnTie
            {
                get
                {
                    this.m_DPP_AbnTie = MyProject.MyForms.Create__Instance__<DPP_AbnTie>(this.m_DPP_AbnTie);
                    return this.m_DPP_AbnTie;
                }
                set
                {
                    if (value == this.m_DPP_AbnTie)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<DPP_AbnTie>(ref this.m_DPP_AbnTie);
                }
            }

            // Token: 0x17000015 RID: 21
            // (get) Token: 0x0600001A RID: 26 RVA: 0x0027678C File Offset: 0x00274B8C
            // (set) Token: 0x0600005C RID: 92 RVA: 0x00277110 File Offset: 0x00275510
            public DPP_CUP DPP_CUP
            {
                get
                {
                    this.m_DPP_CUP = MyProject.MyForms.Create__Instance__<DPP_CUP>(this.m_DPP_CUP);
                    return this.m_DPP_CUP;
                }
                set
                {
                    if (value == this.m_DPP_CUP)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<DPP_CUP>(ref this.m_DPP_CUP);
                }
            }

            // Token: 0x17000016 RID: 22
            // (get) Token: 0x0600001B RID: 27 RVA: 0x002767B0 File Offset: 0x00274BB0
            // (set) Token: 0x0600005D RID: 93 RVA: 0x00277138 File Offset: 0x00275538
            public DPP_Match DPP_Match
            {
                get
                {
                    this.m_DPP_Match = MyProject.MyForms.Create__Instance__<DPP_Match>(this.m_DPP_Match);
                    return this.m_DPP_Match;
                }
                set
                {
                    if (value == this.m_DPP_Match)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<DPP_Match>(ref this.m_DPP_Match);
                }
            }

            // Token: 0x17000017 RID: 23
            // (get) Token: 0x0600001C RID: 28 RVA: 0x002767D4 File Offset: 0x00274BD4
            // (set) Token: 0x0600005E RID: 94 RVA: 0x00277160 File Offset: 0x00275560
            //         public Final_Trial_Balance Final_Trial_Balance
            //{
            //	get
            //	{
            //		this.m_Final_Trial_Balance = MyProject.MyForms.Create__Instance__<Final_Trial_Balance>(this.m_Final_Trial_Balance);
            //		return this.m_Final_Trial_Balance;
            //	}
            //	set
            //	{
            //		if (value == this.m_Final_Trial_Balance)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<Final_Trial_Balance>(ref this.m_Final_Trial_Balance);
            //	}
            //}

            // Token: 0x17000018 RID: 24
            // (get) Token: 0x0600001D RID: 29 RVA: 0x002767F8 File Offset: 0x00274BF8
            // (set) Token: 0x0600005F RID: 95 RVA: 0x00277188 File Offset: 0x00275588
            //public Find_Sauda_Entry Find_Sauda_Entry
            //{
            //	get
            //	{
            //		this.m_Find_Sauda_Entry = MyProject.MyForms.Create__Instance__<Find_Sauda_Entry>(this.m_Find_Sauda_Entry);
            //		return this.m_Find_Sauda_Entry;
            //	}
            //	set
            //	{
            //		if (value == this.m_Find_Sauda_Entry)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<Find_Sauda_Entry>(ref this.m_Find_Sauda_Entry);
            //	}
            //}

            //// Token: 0x17000019 RID: 25
            //// (get) Token: 0x0600001E RID: 30 RVA: 0x0027681C File Offset: 0x00274C1C
            //// (set) Token: 0x06000060 RID: 96 RVA: 0x002771B0 File Offset: 0x002755B0
            //public findnewmatch findnewmatch
            //{
            //    get
            //    {
            //        this.m_findnewmatch = MyProject.MyForms.Create__Instance__<findnewmatch>(this.m_findnewmatch);
            //        return this.m_findnewmatch;
            //    }
            //    set
            //    {
            //        if (value == this.m_findnewmatch)
            //        {
            //            return;
            //        }
            //        if (value != null)
            //        {
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        }
            //        this.Dispose__Instance__<findnewmatch>(ref this.m_findnewmatch);
            //    }
            //}


            // Token: 0x1700001A RID: 26
            // (get) Token: 0x0600001F RID: 31 RVA: 0x00276840 File Offset: 0x00274C40
            // (set) Token: 0x06000061 RID: 97 RVA: 0x002771D8 File Offset: 0x002755D8
            public Form1 Form1
            {
                get
                {
                    this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
                    return this.m_Form1;
                }
                set
                {
                    if (value == this.m_Form1)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Form1>(ref this.m_Form1);
                }
            }

            // Token: 0x1700001B RID: 27
            // (get) Token: 0x06000020 RID: 32 RVA: 0x00276864 File Offset: 0x00274C64
            // (set) Token: 0x06000062 RID: 98 RVA: 0x00277200 File Offset: 0x00275600
            public Form3_SESSION Form3_SESSION
            {
                get
                {
                    this.m_Form3_SESSION = MyProject.MyForms.Create__Instance__<Form3_SESSION>(this.m_Form3_SESSION);
                    return this.m_Form3_SESSION;
                }
                set
                {
                    if (value == this.m_Form3_SESSION)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Form3_SESSION>(ref this.m_Form3_SESSION);
                }
            }

            // Token: 0x1700001C RID: 28
            // (get) Token: 0x06000021 RID: 33 RVA: 0x00276888 File Offset: 0x00274C88
            // (set) Token: 0x06000063 RID: 99 RVA: 0x00277228 File Offset: 0x00275628
            public formDPPSession formDPPSession
            {
                get
                {
                    this.m_formDPPSession = MyProject.MyForms.Create__Instance__<formDPPSession>(this.m_formDPPSession);
                    return this.m_formDPPSession;
                }
                set
                {
                    if (value == this.m_formDPPSession)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<formDPPSession>(ref this.m_formDPPSession);
                }
            }

            // Token: 0x1700001D RID: 29
            // (get) Token: 0x06000022 RID: 34 RVA: 0x002768AC File Offset: 0x00274CAC
            // (set) Token: 0x06000064 RID: 100 RVA: 0x00277250 File Offset: 0x00275650
            //public Formftb_Print Formftb_Print
            //{
            //	get
            //	{
            //		this.m_Formftb_Print = MyProject.MyForms.Create__Instance__<Formftb_Print>(this.m_Formftb_Print);
            //		return this.m_Formftb_Print;
            //	}
            //	set
            //	{
            //		if (value == this.m_Formftb_Print)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<Formftb_Print>(ref this.m_Formftb_Print);
            //	}
            //}

            // Token: 0x1700001E RID: 30
            // (get) Token: 0x06000023 RID: 35 RVA: 0x002768D0 File Offset: 0x00274CD0
            // (set) Token: 0x06000065 RID: 101 RVA: 0x00277278 File Offset: 0x00275678
            //public Formmatchbookprint Formmatchbookprint
            //{
            //	get
            //	{
            //		this.m_Formmatchbookprint = MyProject.MyForms.Create__Instance__<Formmatchbookprint>(this.m_Formmatchbookprint);
            //		return this.m_Formmatchbookprint;
            //	}
            //	set
            //	{
            //		if (value == this.m_Formmatchbookprint)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<Formmatchbookprint>(ref this.m_Formmatchbookprint);
            //	}
            //}

            // Token: 0x1700001F RID: 31
            // (get) Token: 0x06000024 RID: 36 RVA: 0x002768F4 File Offset: 0x00274CF4
            // (set) Token: 0x06000066 RID: 102 RVA: 0x002772A0 File Offset: 0x002756A0
            //public Frm_FinalSudaEntry Frm_FinalSudaEntry
            //{
            //	get
            //	{
            //		this.m_Frm_FinalSudaEntry = MyProject.MyForms.Create__Instance__<Frm_FinalSudaEntry>(this.m_Frm_FinalSudaEntry);
            //		return this.m_Frm_FinalSudaEntry;
            //	}
            //	set
            //	{
            //		if (value == this.m_Frm_FinalSudaEntry)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<Frm_FinalSudaEntry>(ref this.m_Frm_FinalSudaEntry);
            //	}
            //}

            // Token: 0x17000020 RID: 32
            // (get) Token: 0x06000025 RID: 37 RVA: 0x00276918 File Offset: 0x00274D18
            // (set) Token: 0x06000067 RID: 103 RVA: 0x002772C8 File Offset: 0x002756C8
            //public fromAbn fromAbn
            //{
            //    get
            //    {
            //        this.m_fromAbn = MyProject.MyForms.Create__Instance__<fromAbn>(this.m_fromAbn);
            //        return this.m_fromAbn;
            //    }
            //    set
            //    {
            //        if (value == this.m_fromAbn)
            //        {
            //            return;
            //        }
            //        if (value != null)
            //        {
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        }
            //        this.Dispose__Instance__<fromAbn>(ref this.m_fromAbn);
            //    }
            //}

            // Token: 0x17000021 RID: 33
            // (get) Token: 0x06000026 RID: 38 RVA: 0x0027693C File Offset: 0x00274D3C
            // (set) Token: 0x06000068 RID: 104 RVA: 0x002772F0 File Offset: 0x002756F0
            //public fromagentmatchReport fromagentmatchReport
            //{
            //	get
            //	{
            //		this.m_fromagentmatchReport = MyProject.MyForms.Create__Instance__<fromagentmatchReport>(this.m_fromagentmatchReport);
            //		return this.m_fromagentmatchReport;
            //	}
            //	set
            //	{
            //		if (value == this.m_fromagentmatchReport)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<fromagentmatchReport>(ref this.m_fromagentmatchReport);
            //	}
            //}

            // Token: 0x17000022 RID: 34
            // (get) Token: 0x06000027 RID: 39 RVA: 0x00276960 File Offset: 0x00274D60
            // (set) Token: 0x06000069 RID: 105 RVA: 0x00277318 File Offset: 0x00275718
            public fromAgentSession fromAgentSession
            {
                get
                {
                    this.m_fromAgentSession = MyProject.MyForms.Create__Instance__<fromAgentSession>(this.m_fromAgentSession);
                    return this.m_fromAgentSession;
                }
                set
                {
                    if (value == this.m_fromAgentSession)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<fromAgentSession>(ref this.m_fromAgentSession);
                }
            }

            //// Token: 0x17000023 RID: 35
            //// (get) Token: 0x06000028 RID: 40 RVA: 0x00276984 File Offset: 0x00274D84
            //// (set) Token: 0x0600006A RID: 106 RVA: 0x00277340 File Offset: 0x00275740
            //public fromakd fromakd
            //{
            //    get
            //    {
            //        this.m_fromakd = MyProject.MyForms.Create__Instance__<fromakd>(this.m_fromakd);
            //        return this.m_fromakd;
            //    }
            //    set
            //    {
            //        if (value == this.m_fromakd)
            //        {
            //            return;
            //        }
            //        if (value != null)
            //        {
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        }
            //        this.Dispose__Instance__<fromakd>(ref this.m_fromakd);
            //    }
            //}

            // Token: 0x17000024 RID: 36
            // (get) Token: 0x06000029 RID: 41 RVA: 0x002769A8 File Offset: 0x00274DA8
            // (set) Token: 0x0600006B RID: 107 RVA: 0x00277368 File Offset: 0x00275768
            //public fromconect_Report fromconect_Report
            //{
            //	get
            //	{
            //		this.m_fromconect_Report = MyProject.MyForms.Create__Instance__<fromconect_Report>(this.m_fromconect_Report);
            //		return this.m_fromconect_Report;
            //	}
            //	set
            //	{
            //		if (value == this.m_fromconect_Report)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<fromconect_Report>(ref this.m_fromconect_Report);
            //	}
            //}

            // Token: 0x17000025 RID: 37
            // (get) Token: 0x0600002A RID: 42 RVA: 0x002769CC File Offset: 0x00274DCC
            // (set) Token: 0x0600006C RID: 108 RVA: 0x00277390 File Offset: 0x00275790
            public fromCUP_Winar fromCUP_Winar
            {
                get
                {
                    this.m_fromCUP_Winar = MyProject.MyForms.Create__Instance__<fromCUP_Winar>(this.m_fromCUP_Winar);
                    return this.m_fromCUP_Winar;
                }
                set
                {
                    if (value == this.m_fromCUP_Winar)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<fromCUP_Winar>(ref this.m_fromCUP_Winar);
                }
            }

            // Token: 0x17000026 RID: 38
            // (get) Token: 0x0600002B RID: 43 RVA: 0x002769F0 File Offset: 0x00274DF0
            // (set) Token: 0x0600006D RID: 109 RVA: 0x002773B8 File Offset: 0x002757B8
            //public fromcupdppPrint fromcupdppPrint
            //{
            //	get
            //	{
            //		this.m_fromcupdppPrint = MyProject.MyForms.Create__Instance__<fromcupdppPrint>(this.m_fromcupdppPrint);
            //		return this.m_fromcupdppPrint;
            //	}
            //	set
            //	{
            //		if (value == this.m_fromcupdppPrint)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<fromcupdppPrint>(ref this.m_fromcupdppPrint);
            //	}
            //}

            // Token: 0x17000027 RID: 39
            // (get) Token: 0x0600002C RID: 44 RVA: 0x00276A14 File Offset: 0x00274E14
            // (set) Token: 0x0600006E RID: 110 RVA: 0x002773E0 File Offset: 0x002757E0
            public frommatchDecleard frommatchDecleard
            {
                get
                {
                    this.m_frommatchDecleard = MyProject.MyForms.Create__Instance__<frommatchDecleard>(this.m_frommatchDecleard);
                    return this.m_frommatchDecleard;
                }
                set
                {
                    if (value == this.m_frommatchDecleard)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<frommatchDecleard>(ref this.m_frommatchDecleard);
                }
            }

            // Token: 0x17000028 RID: 40
            // (get) Token: 0x0600002D RID: 45 RVA: 0x00276A38 File Offset: 0x00274E38
            // (set) Token: 0x0600006F RID: 111 RVA: 0x00277408 File Offset: 0x00275808
            //public fromMatchdpp fromMatchdpp
            //{
            //	get
            //	{
            //		this.m_fromMatchdpp = MyProject.MyForms.Create__Instance__<fromMatchdpp>(this.m_fromMatchdpp);
            //		return this.m_fromMatchdpp;
            //	}
            //	set
            //	{
            //		if (value == this.m_fromMatchdpp)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<fromMatchdpp>(ref this.m_fromMatchdpp);
            //	}
            //}

            // Token: 0x17000029 RID: 41
            // (get) Token: 0x0600002E RID: 46 RVA: 0x00276A5C File Offset: 0x00274E5C
            // (set) Token: 0x06000070 RID: 112 RVA: 0x00277430 File Offset: 0x00275830
            public Hawala_Report Hawala_Report
            {
                get
                {
                    this.m_Hawala_Report = MyProject.MyForms.Create__Instance__<Hawala_Report>(this.m_Hawala_Report);
                    return this.m_Hawala_Report;
                }
                set
                {
                    if (value == this.m_Hawala_Report)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Hawala_Report>(ref this.m_Hawala_Report);
                }
            }

            // Token: 0x1700002A RID: 42
            // (get) Token: 0x0600002F RID: 47 RVA: 0x00276A80 File Offset: 0x00274E80
            // (set) Token: 0x06000071 RID: 113 RVA: 0x00277458 File Offset: 0x00275858
            //public Hawla_Print Hawla_Print
            //{
            //	get
            //	{
            //		this.m_Hawla_Print = MyProject.MyForms.Create__Instance__<Hawla_Print>(this.m_Hawla_Print);
            //		return this.m_Hawla_Print;
            //	}
            //	set
            //	{
            //		if (value == this.m_Hawla_Print)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<Hawla_Print>(ref this.m_Hawla_Print);
            //	}
            //}

            // Token: 0x1700002B RID: 43
            // (get) Token: 0x06000030 RID: 48 RVA: 0x00276AA4 File Offset: 0x00274EA4
            // (set) Token: 0x06000072 RID: 114 RVA: 0x00277480 File Offset: 0x00275880
            public IMP_DATA IMP_DATA
            {
                get
                {
                    this.m_IMP_DATA = MyProject.MyForms.Create__Instance__<IMP_DATA>(this.m_IMP_DATA);
                    return this.m_IMP_DATA;
                }
                set
                {
                    if (value == this.m_IMP_DATA)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<IMP_DATA>(ref this.m_IMP_DATA);
                }
            }

            // Token: 0x1700002C RID: 44
            // (get) Token: 0x06000031 RID: 49 RVA: 0x00276AC8 File Offset: 0x00274EC8
            // (set) Token: 0x06000073 RID: 115 RVA: 0x002774A8 File Offset: 0x002758A8
            //public Kbys Kbys
            //{
            //	get
            //	{
            //		this.m_Kbys = MyProject.MyForms.Create__Instance__<Kbys>(this.m_Kbys);
            //		return this.m_Kbys;
            //	}
            //	set
            //	{
            //		if (value == this.m_Kbys)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<Kbys>(ref this.m_Kbys);
            //	}
            //}


            //// Token: 0x1700002D RID: 45
            //// (get) Token: 0x06000032 RID: 50 RVA: 0x00276AEC File Offset: 0x00274EEC
            //// (set) Token: 0x06000074 RID: 116 RVA: 0x002774D0 File Offset: 0x002758D0

            //public frmRegistration frmRegistration
            //{
            //    get
            //    {
            //        this.m_frmRegistration = MyProject.MyForms.Create__Instance__<frmRegistration>(this.m_frmRegistration);
            //        return this.m_frmRegistration;
            //    }
            //    set
            //    {
            //        if (value == this.m_frmRegistration)
            //        {
            //            return;
            //        }
            //        if (value != null)
            //        {
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        }
            //        this.Dispose__Instance__<frmRegistration>(ref this.m_frmRegistration);
            //    }
            //}

            public Login Login
            {
                get
                {
                    this.m_Login = MyProject.MyForms.Create__Instance__<Login>(this.m_Login);
                    return this.m_Login;
                }
                set
                {
                    if (value == this.m_Login)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Login>(ref this.m_Login);
                }
            }


            // Token: 0x1700002E RID: 46
            // (get) Token: 0x06000033 RID: 51 RVA: 0x00276B10 File Offset: 0x00274F10
            // (set) Token: 0x06000075 RID: 117 RVA: 0x002774F8 File Offset: 0x002758F8
            public Match Match
            {
                get
                {
                    this.m_Match = MyProject.MyForms.Create__Instance__<Match>(this.m_Match);
                    return this.m_Match;
                }
                set
                {
                    if (value == this.m_Match)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Match>(ref this.m_Match);
                }
            }

            // Token: 0x1700002F RID: 47
            // (get) Token: 0x06000034 RID: 52 RVA: 0x00276B34 File Offset: 0x00274F34
            // (set) Token: 0x06000076 RID: 118 RVA: 0x00277520 File Offset: 0x00275920
            public Match_Book Match_Book
            {
                get
                {
                    this.m_Match_Book = MyProject.MyForms.Create__Instance__<Match_Book>(this.m_Match_Book);
                    return this.m_Match_Book;
                }
                set
                {
                    if (value == this.m_Match_Book)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Match_Book>(ref this.m_Match_Book);
                }
            }

            // Token: 0x17000030 RID: 48
            // (get) Token: 0x06000035 RID: 53 RVA: 0x00276B58 File Offset: 0x00274F58
            // (set) Token: 0x06000077 RID: 119 RVA: 0x00277548 File Offset: 0x00275948
            public Match_Report Match_Report
            {
                get
                {
                    this.m_Match_Report = MyProject.MyForms.Create__Instance__<Match_Report>(this.m_Match_Report);
                    return this.m_Match_Report;
                }
                set
                {
                    if (value == this.m_Match_Report)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Match_Report>(ref this.m_Match_Report);
                }
            }

            // Token: 0x17000031 RID: 49
            // (get) Token: 0x06000036 RID: 54 RVA: 0x00276B7C File Offset: 0x00274F7C
            // (set) Token: 0x06000078 RID: 120 RVA: 0x00277570 File Offset: 0x00275970
            public MatchBOOKPOPUP MatchBOOKPOPUP
            {
                get
                {
                    this.m_MatchBOOKPOPUP = MyProject.MyForms.Create__Instance__<MatchBOOKPOPUP>(this.m_MatchBOOKPOPUP);
                    return this.m_MatchBOOKPOPUP;
                }
                set
                {
                    if (value == this.m_MatchBOOKPOPUP)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<MatchBOOKPOPUP>(ref this.m_MatchBOOKPOPUP);
                }
            }

            //// Token: 0x17000032 RID: 50
            //// (get) Token: 0x06000037 RID: 55 RVA: 0x00276BA0 File Offset: 0x00274FA0
            //// (set) Token: 0x06000079 RID: 121 RVA: 0x00277598 File Offset: 0x00275998
            //public modifySession modifySession
            //{
            //    get
            //    {
            //        this.m_modifySession = MyProject.MyForms.Create__Instance__<modifySession>(this.m_modifySession);
            //        return this.m_modifySession;
            //    }
            //    set
            //    {
            //        if (value == this.m_modifySession)
            //        {
            //            return;
            //        }
            //        if (value != null)
            //        {
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        }
            //        this.Dispose__Instance__<modifySession>(ref this.m_modifySession);
            //    }
            //}

            // Token: 0x17000033 RID: 51
            // (get) Token: 0x06000038 RID: 56 RVA: 0x00276BC4 File Offset: 0x00274FC4
            // (set) Token: 0x0600007A RID: 122 RVA: 0x002775C0 File Offset: 0x002759C0
            //public MSG_ALL MSG_ALL
            //{
            //	get
            //	{
            //		this.m_MSG_ALL = MyProject.MyForms.Create__Instance__<MSG_ALL>(this.m_MSG_ALL);
            //		return this.m_MSG_ALL;
            //	}
            //	set
            //	{
            //		if (value == this.m_MSG_ALL)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<MSG_ALL>(ref this.m_MSG_ALL);
            //	}
            //}

            // Token: 0x17000034 RID: 52
            // (get) Token: 0x06000039 RID: 57 RVA: 0x00276BE8 File Offset: 0x00274FE8
            // (set) Token: 0x0600007B RID: 123 RVA: 0x002775E8 File Offset: 0x002759E8
            //public MY_HOME MY_HOME
            //{
            //	get
            //	{
            //		this.m_MY_HOME = MyProject.MyForms.Create__Instance__<MY_HOME>(this.m_MY_HOME);
            //		return this.m_MY_HOME;
            //	}
            //	set
            //	{
            //		if (value == this.m_MY_HOME)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<MY_HOME>(ref this.m_MY_HOME);
            //	}
            //}

            // Token: 0x17000035 RID: 53
            // (get) Token: 0x0600003A RID: 58 RVA: 0x00276C0C File Offset: 0x0027500C
            // (set) Token: 0x0600007C RID: 124 RVA: 0x00277610 File Offset: 0x00275A10
            public New_Connect New_Connect
            {
                get
                {
                    this.m_New_Connect = MyProject.MyForms.Create__Instance__<New_Connect>(this.m_New_Connect);
                    return this.m_New_Connect;
                }
                set
                {
                    if (value == this.m_New_Connect)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<New_Connect>(ref this.m_New_Connect);
                }
            }

            // Token: 0x17000036 RID: 54
            // (get) Token: 0x0600003B RID: 59 RVA: 0x00276C30 File Offset: 0x00275030
            // (set) Token: 0x0600007D RID: 125 RVA: 0x00277638 File Offset: 0x00275A38
            public New_Match New_Match
            {
                get
                {
                    this.m_New_Match = MyProject.MyForms.Create__Instance__<New_Match>(this.m_New_Match);
                    return this.m_New_Match;
                }
                set
                {
                    if (value == this.m_New_Match)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<New_Match>(ref this.m_New_Match);
                }
            }

            // Token: 0x17000037 RID: 55
            // (get) Token: 0x0600003C RID: 60 RVA: 0x00276C54 File Offset: 0x00275054
            // (set) Token: 0x0600007E RID: 126 RVA: 0x00277660 File Offset: 0x00275A60
            public New_Party New_Party
            {
                get
                {
                    this.m_New_Party = MyProject.MyForms.Create__Instance__<New_Party>(this.m_New_Party);
                    return this.m_New_Party;
                }
                set
                {
                    if (value == this.m_New_Party)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<New_Party>(ref this.m_New_Party);
                }
            }

            // Token: 0x17000038 RID: 56
            // (get) Token: 0x0600003D RID: 61 RVA: 0x00276C78 File Offset: 0x00275078
            // (set) Token: 0x0600007F RID: 127 RVA: 0x00277688 File Offset: 0x00275A88
            public New_Session New_Session
            {
                get
                {
                    this.m_New_Session = MyProject.MyForms.Create__Instance__<New_Session>(this.m_New_Session);
                    return this.m_New_Session;
                }
                set
                {
                    if (value == this.m_New_Session)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<New_Session>(ref this.m_New_Session);
                }
            }


            // Token: 0x1700003A RID: 58
            // (get) Token: 0x0600003F RID: 63 RVA: 0x00276CC0 File Offset: 0x002750C0
            // (set) Token: 0x06000081 RID: 129 RVA: 0x002776D8 File Offset: 0x00275AD8
            public Party_Report Party_Report
            {
                get
                {
                    this.m_Party_Report = MyProject.MyForms.Create__Instance__<Party_Report>(this.m_Party_Report);
                    return this.m_Party_Report;
                }
                set
                {
                    if (value == this.m_Party_Report)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Party_Report>(ref this.m_Party_Report);
                }
            }

            // Token: 0x1700003B RID: 59
            // (get) Token: 0x06000040 RID: 64 RVA: 0x00276CE4 File Offset: 0x002750E4
            // (set) Token: 0x06000082 RID: 130 RVA: 0x00277700 File Offset: 0x00275B00
            //public Partyname_Print Partyname_Print
            //{
            //	get
            //	{
            //		this.m_Partyname_Print = MyProject.MyForms.Create__Instance__<Partyname_Print>(this.m_Partyname_Print);
            //		return this.m_Partyname_Print;
            //	}
            //	set
            //	{
            //		if (value == this.m_Partyname_Print)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<Partyname_Print>(ref this.m_Partyname_Print);
            //	}
            //}

            // Token: 0x1700003C RID: 60
            // (get) Token: 0x06000041 RID: 65 RVA: 0x00276D08 File Offset: 0x00275108
            // (set) Token: 0x06000083 RID: 131 RVA: 0x00277728 File Offset: 0x00275B28
            public PrevoiusData PrevoiusData
            {
                get
                {
                    this.m_PrevoiusData = MyProject.MyForms.Create__Instance__<PrevoiusData>(this.m_PrevoiusData);
                    return this.m_PrevoiusData;
                }
                set
                {
                    if (value == this.m_PrevoiusData)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<PrevoiusData>(ref this.m_PrevoiusData);
                }
            }

            // Token: 0x1700003D RID: 61
            // (get) Token: 0x06000042 RID: 66 RVA: 0x00276D2C File Offset: 0x0027512C
            // (set) Token: 0x06000084 RID: 132 RVA: 0x00277750 File Offset: 0x00275B50
            public print_view print_view
            {
                get
                {
                    this.m_print_view = MyProject.MyForms.Create__Instance__<print_view>(this.m_print_view);
                    return this.m_print_view;
                }
                set
                {
                    if (value == this.m_print_view)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<print_view>(ref this.m_print_view);
                }
            }

            // Token: 0x1700003E RID: 62
            // (get) Token: 0x06000043 RID: 67 RVA: 0x00276D50 File Offset: 0x00275150
            // (set) Token: 0x06000085 RID: 133 RVA: 0x00277778 File Offset: 0x00275B78
            //public SDDPDialog SDDPDialog
            //{
            //	get
            //	{
            //		this.m_SDDPDialog = MyProject.MyForms.Create__Instance__<SDDPDialog>(this.m_SDDPDialog);
            //		return this.m_SDDPDialog;
            //	}
            //	set
            //	{
            //		if (value == this.m_SDDPDialog)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<SDDPDialog>(ref this.m_SDDPDialog);
            //	}
            //}

            // Token: 0x1700003F RID: 63
            // (get) Token: 0x06000044 RID: 68 RVA: 0x00276D74 File Offset: 0x00275174
            // (set) Token: 0x06000086 RID: 134 RVA: 0x002777A0 File Offset: 0x00275BA0
            public Session_Report Session_Report
            {
                get
                {
                    this.m_Session_Report = MyProject.MyForms.Create__Instance__<Session_Report>(this.m_Session_Report);
                    return this.m_Session_Report;
                }
                set
                {
                    if (value == this.m_Session_Report)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Session_Report>(ref this.m_Session_Report);
                }
            }

            // Token: 0x17000040 RID: 64
            // (get) Token: 0x06000045 RID: 69 RVA: 0x00276D98 File Offset: 0x00275198
            // (set) Token: 0x06000087 RID: 135 RVA: 0x002777C8 File Offset: 0x00275BC8
            //public SessionDelear SessionDelear
            //{
            //	get
            //	{
            //		this.m_SessionDelear = MyProject.MyForms.Create__Instance__<SessionDelear>(this.m_SessionDelear);
            //		return this.m_SessionDelear;
            //	}
            //	set
            //	{
            //		if (value == this.m_SessionDelear)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<SessionDelear>(ref this.m_SessionDelear);
            //	}
            //}

            // Token: 0x17000041 RID: 65
            // (get) Token: 0x06000046 RID: 70 RVA: 0x00276DBC File Offset: 0x002751BC
            // (set) Token: 0x06000088 RID: 136 RVA: 0x002777F0 File Offset: 0x00275BF0
            public Setings Setings
            {
                get
                {
                    this.m_Setings = MyProject.MyForms.Create__Instance__<Setings>(this.m_Setings);
                    return this.m_Setings;
                }
                set
                {
                    if (value == this.m_Setings)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Setings>(ref this.m_Setings);
                }
            }

            // Token: 0x17000042 RID: 66
            // (get) Token: 0x06000047 RID: 71 RVA: 0x00276DE0 File Offset: 0x002751E0
            // (set) Token: 0x06000089 RID: 137 RVA: 0x00277818 File Offset: 0x00275C18
            public Setlement_Report Setlement_Report
            {
                get
                {
                    this.m_Setlement_Report = MyProject.MyForms.Create__Instance__<Setlement_Report>(this.m_Setlement_Report);
                    return this.m_Setlement_Report;
                }
                set
                {
                    if (value == this.m_Setlement_Report)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Setlement_Report>(ref this.m_Setlement_Report);
                }
            }

            // Token: 0x17000043 RID: 67
            // (get) Token: 0x06000048 RID: 72 RVA: 0x00276E04 File Offset: 0x00275204
            // (set) Token: 0x0600008A RID: 138 RVA: 0x00277840 File Offset: 0x00275C40
            public Toss_Delcler Toss_Delcler
            {
                get
                {
                    this.m_Toss_Delcler = MyProject.MyForms.Create__Instance__<Toss_Delcler>(this.m_Toss_Delcler);
                    return this.m_Toss_Delcler;
                }
                set
                {
                    if (value == this.m_Toss_Delcler)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Toss_Delcler>(ref this.m_Toss_Delcler);
                }
            }

            // Token: 0x17000044 RID: 68
            // (get) Token: 0x06000049 RID: 73 RVA: 0x00276E28 File Offset: 0x00275228
            // (set) Token: 0x0600008B RID: 139 RVA: 0x00277868 File Offset: 0x00275C68
            public Toss_Match Toss_Match
            {
                get
                {
                    this.m_Toss_Match = MyProject.MyForms.Create__Instance__<Toss_Match>(this.m_Toss_Match);
                    return this.m_Toss_Match;
                }
                set
                {
                    if (value == this.m_Toss_Match)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Toss_Match>(ref this.m_Toss_Match);
                }
            }

            // Token: 0x17000045 RID: 69
            // (get) Token: 0x0600004A RID: 74 RVA: 0x00276E4C File Offset: 0x0027524C
            // (set) Token: 0x0600008C RID: 140 RVA: 0x00277890 File Offset: 0x00275C90
            public Toss_Reports Toss_Reports
            {
                get
                {
                    this.m_Toss_Reports = MyProject.MyForms.Create__Instance__<Toss_Reports>(this.m_Toss_Reports);
                    return this.m_Toss_Reports;
                }
                set
                {
                    if (value == this.m_Toss_Reports)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Toss_Reports>(ref this.m_Toss_Reports);
                }
            }

            // Token: 0x17000046 RID: 70
            // (get) Token: 0x0600004B RID: 75 RVA: 0x00276E70 File Offset: 0x00275270
            // (set) Token: 0x0600008D RID: 141 RVA: 0x002778B8 File Offset: 0x00275CB8
            //public Tran_Dialog_Report Tran_Dialog_Report
            //{
            //	get
            //	{
            //		this.m_Tran_Dialog_Report = MyProject.MyForms.Create__Instance__<Tran_Dialog_Report>(this.m_Tran_Dialog_Report);
            //		return this.m_Tran_Dialog_Report;
            //	}
            //	set
            //	{
            //		if (value == this.m_Tran_Dialog_Report)
            //		{
            //			return;
            //		}
            //		if (value != null)
            //		{
            //			throw new ArgumentException("Property can only be set to Nothing");
            //		}
            //		this.Dispose__Instance__<Tran_Dialog_Report>(ref this.m_Tran_Dialog_Report);
            //	}
            //}

            //// Token: 0x17000047 RID: 71
            //// (get) Token: 0x0600004C RID: 76 RVA: 0x00276E94 File Offset: 0x00275294
            //// (set) Token: 0x0600008E RID: 142 RVA: 0x002778E0 File Offset: 0x00275CE0
            //public TransactionReport TransactionReport
            //{
            //    get
            //    {
            //        this.m_TransactionReport = MyProject.MyForms.Create__Instance__<TransactionReport>(this.m_TransactionReport);
            //        return this.m_TransactionReport;
            //    }
            //    set
            //    {
            //        if (value == this.m_TransactionReport)
            //        {
            //            return;
            //        }
            //        if (value != null)
            //        {
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        }
            //        this.Dispose__Instance__<TransactionReport>(ref this.m_TransactionReport);
            //    }
            //}

            public AccountLedger AccountLedger
            {
                get
                {
                    this.m_AccountLedger = MyProject.MyForms.Create__Instance__<AccountLedger>(this.m_AccountLedger);
                    return this.m_AccountLedger;
                }
                set
                {
                    if (value == this.m_AccountLedger)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<AccountLedger>(ref this.m_AccountLedger);
                }
            }

            public DPP_Toss DPP_Toss
            {
                get
                {
                    this.m_DPP_Toss = MyProject.MyForms.Create__Instance__<DPP_Toss>(this.m_DPP_Toss);
                    return this.m_DPP_Toss;
                }
                set
                {
                    if (value == this.m_DPP_Toss)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<DPP_Toss>(ref this.m_DPP_Toss);
                }
            }

            // Token: 0x0600008F RID: 143 RVA: 0x00277908 File Offset: 0x00275D08
            [DebuggerHidden]
            private static T Create__Instance__<T>(T Instance) where T : Form, new()
            {
                if (Instance == null || Instance.IsDisposed)
                {
                    if (MyProject.MyForms.m_FormBeingCreated != null)
                    {
                        if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
                        {
                            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
                        }
                    }
                    else
                    {
                        MyProject.MyForms.m_FormBeingCreated = new Hashtable();
                    }
                    MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
                    try
                    {
                        return Activator.CreateInstance<T>();
                    }
                    catch (TargetInvocationException ex) when (ex.InnerException != null)
                    {
                        string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
                        {
                            ex.InnerException.Message
                        });
                        throw new InvalidOperationException(resourceString, ex.InnerException);
                    }
                    finally
                    {
                        MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
                    }
                    return Instance;
                }
                return Instance;
            }

            // Token: 0x06000090 RID: 144 RVA: 0x00277A14 File Offset: 0x00275E14
            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) where T : Form
            {
                instance.Dispose();
                instance = default(T);
            }

            // Token: 0x06000091 RID: 145 RVA: 0x00277A3C File Offset: 0x00275E3C
            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            public MyForms()
            {
            }

            // Token: 0x06000092 RID: 146 RVA: 0x00277A44 File Offset: 0x00275E44
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            // Token: 0x06000093 RID: 147 RVA: 0x00277A60 File Offset: 0x00275E60
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            // Token: 0x06000094 RID: 148 RVA: 0x00277A74 File Offset: 0x00275E74
            [EditorBrowsable(EditorBrowsableState.Never)]
            internal new Type GetType()
            {
                return typeof(MyProject.MyForms);
            }

            // Token: 0x06000095 RID: 149 RVA: 0x00277A8C File Offset: 0x00275E8C
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return base.ToString();
            }

            // Token: 0x04000006 RID: 6
            public Agent_abntie m_Agent_abntie;

            // Token: 0x04000007 RID: 7
            public Agent_CUP m_Agent_CUP;

            // Token: 0x04000008 RID: 8
            public Agent_match m_Agent_match;

            // Token: 0x04000008 RID: 8
            public Agent_Connect m_Agent_Connect;

            //// Token: 0x04000009 RID: 9
            //public All_Session m_All_Session;

            // Token: 0x0400000A RID: 10
            public Balance_Message m_Balance_Message;

            // Token: 0x0400000B RID: 11
            //public Bit m_Bit;

            // Token: 0x0400000C RID: 12
            //public Boolk_MSG m_Boolk_MSG;

            // Token: 0x0400000D RID: 13
            public CUP m_CUP;

            // Token: 0x0400000E RID: 14
            public Cup_match_Book m_Cup_match_Book;

            //// Token: 0x0400000F RID: 15
            //public Cup_Modify m_Cup_Modify;

            // Token: 0x04000010 RID: 16
            public Cup_Report m_Cup_Report;

            // Token: 0x04000011 RID: 17
            public Declear_New_Sesstions m_Declear_New_Sesstions;

            // Token: 0x04000012 RID: 18
            //public Dialog1 m_Dialog1;

            // Token: 0x04000013 RID: 19
            public Dialog_PriDATA m_Dialog_PriDATA;

            // Token: 0x04000014 RID: 20
            public DPP_AbnTie m_DPP_AbnTie;

            // Token: 0x04000015 RID: 21
            public DPP_CUP m_DPP_CUP;

            // Token: 0x04000016 RID: 22
            public DPP_Match m_DPP_Match;

            // Token: 0x04000017 RID: 23
            public Final_Trial_Balance m_Final_Trial_Balance;

            // Token: 0x04000018 RID: 24
            //public Find_Sauda_Entry m_Find_Sauda_Entry;

            //// Token: 0x04000019 RID: 25
            //public findnewmatch m_findnewmatch;

            // Token: 0x0400001A RID: 26
            public Form1 m_Form1;

            // Token: 0x0400001B RID: 27
            public Form3_SESSION m_Form3_SESSION;

            // Token: 0x0400001C RID: 28
            public formDPPSession m_formDPPSession;

            // Token: 0x0400001D RID: 29
            //public Formftb_Print m_Formftb_Print;

            // Token: 0x0400001E RID: 30
            //public Formmatchbookprint m_Formmatchbookprint;

            // Token: 0x0400001F RID: 31
            //public Frm_FinalSudaEntry m_Frm_FinalSudaEntry;

            // Token: 0x04000020 RID: 32
            public fromAbn m_fromAbn;

            // Token: 0x04000021 RID: 33
            //public fromagentmatchReport m_fromagentmatchReport;

            // Token: 0x04000022 RID: 34
            public fromAgentSession m_fromAgentSession;

            //// Token: 0x04000023 RID: 35
            //public fromakd m_fromakd;

            // Token: 0x04000024 RID: 36
            //public fromconect_Report m_fromconect_Report;

            // Token: 0x04000025 RID: 37
            public fromCUP_Winar m_fromCUP_Winar;

            // Token: 0x04000026 RID: 38
            //public fromcupdppPrint m_fromcupdppPrint;

            // Token: 0x04000027 RID: 39
            public frommatchDecleard m_frommatchDecleard;

            // Token: 0x04000028 RID: 40
            //public fromMatchdpp m_fromMatchdpp;

            // Token: 0x04000029 RID: 41
            public Hawala_Report m_Hawala_Report;

            // Token: 0x0400002A RID: 42
            //public Hawla_Print m_Hawla_Print;

            // Token: 0x0400002B RID: 43
            public IMP_DATA m_IMP_DATA;

            // Token: 0x0400002C RID: 44
            //public Kbys m_Kbys;

            // Token: 0x0400002D RID: 45

            public frmRegistration m_frmRegistration;

            public Login m_Login;

            // Token: 0x0400002E RID: 46
            public Match m_Match;

            // Token: 0x0400002F RID: 47
            public Match_Book m_Match_Book;

            // Token: 0x04000030 RID: 48
            public Match_Report m_Match_Report;

            // Token: 0x04000031 RID: 49
            public MatchBOOKPOPUP m_MatchBOOKPOPUP;

            //// Token: 0x04000032 RID: 50
            //public modifySession m_modifySession;

            // Token: 0x04000033 RID: 51
            //public MSG_ALL m_MSG_ALL;

            // Token: 0x04000034 RID: 52
            //public MY_HOME m_MY_HOME;

            // Token: 0x04000035 RID: 53
            public New_Connect m_New_Connect;

            // Token: 0x04000036 RID: 54
            public New_Match m_New_Match;

            // Token: 0x04000037 RID: 55
            public New_Party m_New_Party;

            // Token: 0x04000038 RID: 56
            public New_Session m_New_Session;

            // Token: 0x0400003A RID: 58
            public Party_Report m_Party_Report;

            // Token: 0x0400003B RID: 59
            //public Partyname_Print m_Partyname_Print;

            // Token: 0x0400003C RID: 60
            public PrevoiusData m_PrevoiusData;

            // Token: 0x0400003D RID: 61
            public print_view m_print_view;

            // Token: 0x0400003E RID: 62
            //public SDDPDialog m_SDDPDialog;

            // Token: 0x0400003F RID: 63
            public Session_Report m_Session_Report;

            // Token: 0x04000040 RID: 64
            //public SessionDelear m_SessionDelear;

            // Token: 0x04000041 RID: 65
            public Setings m_Setings;

            // Token: 0x04000042 RID: 66
            public Setlement_Report m_Setlement_Report;

            // Token: 0x04000043 RID: 67
            public Toss_Delcler m_Toss_Delcler;

            // Token: 0x04000044 RID: 68
            public Toss_Match m_Toss_Match;

            // Token: 0x04000045 RID: 69
            public Toss_Reports m_Toss_Reports;

            // Token: 0x04000046 RID: 70
            //public Tran_Dialog_Report m_Tran_Dialog_Report;

            public AccountLedger m_AccountLedger;

            public DPP_Toss m_DPP_Toss;

            //// Token: 0x04000047 RID: 71
            //public TransactionReport m_TransactionReport;

            // Token: 0x04000048 RID: 72
            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;
        }

        // Token: 0x02000006 RID: 6
        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyWebServices
        {
            // Token: 0x06000096 RID: 150 RVA: 0x00277AA0 File Offset: 0x00275EA0
            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            // Token: 0x06000097 RID: 151 RVA: 0x00277ABC File Offset: 0x00275EBC
            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            // Token: 0x06000098 RID: 152 RVA: 0x00277AD0 File Offset: 0x00275ED0
            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            internal new Type GetType()
            {
                return typeof(MyProject.MyWebServices);
            }

            // Token: 0x06000099 RID: 153 RVA: 0x00277AE8 File Offset: 0x00275EE8
            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return base.ToString();
            }

            // Token: 0x0600009A RID: 154 RVA: 0x00277AFC File Offset: 0x00275EFC
            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T : new()
            {
                if (instance == null)
                {
                    return Activator.CreateInstance<T>();
                }
                return instance;
            }

            // Token: 0x0600009B RID: 155 RVA: 0x00277B18 File Offset: 0x00275F18
            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                instance = default(T);
            }

            // Token: 0x0600009C RID: 156 RVA: 0x00277B34 File Offset: 0x00275F34
            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public MyWebServices()
            {
            }
        }

        // Token: 0x02000007 RID: 7
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T : new()
        {
            // Token: 0x17000048 RID: 72
            // (get) Token: 0x0600009D RID: 157 RVA: 0x00277B3C File Offset: 0x00275F3C
            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
                    {
                        MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
                    }
                    return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
                }
            }

            // Token: 0x0600009E RID: 158 RVA: 0x00277B64 File Offset: 0x00275F64
            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            public ThreadSafeObjectProvider()
            {
            }

            // Token: 0x04000049 RID: 73
            [CompilerGenerated]
            [ThreadStatic]
            private static T m_ThreadStaticValue;
        }
    }
}
