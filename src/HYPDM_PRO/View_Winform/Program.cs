﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using HYBPMLib;

namespace View_Winform
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");


            //Application.Run(new SystemManagementAndTools.UserGroupManage.UserGroupList());

            //Application.Run(new SystemManagementAndTools.SystemUserMessageManage.UserList());

            //Application.Run(new SystemManagementAndTools.RoleManage.RoleList());
            //Application.Run(new SystemManagementAndTools.RoleManage.RoleList());
            //Application.Run(new SystemManagementAndTools.OrganizationManage.OrganizationList()); 
            //Application.Run(new DocManage.DocPnt.DocPrint());
            //Application.Run(new Test.TestForm());

            //Application.Run(new PartsMange.MaterialBankManage.MaterialPropertyBuild());
            //string path = Application.ExecutablePath + ".config";
            //BP.DA.ClassFactory.LoadConfig(path);
            //BP.SystemConfig.IsBSsystem = false;
            //FlowCommon common = new FlowCommon();
            //common.Login("zhoushengyu");

            //Application.Run(new BPM.TestForm());

            //Application.Run(new LoginForm());
            //Application.Run(new PartsMange.MaterialBankManage.MaterialPropertyBuild());
            Application.Run(new ProductStructureManage.DeployInformationManage.BOMInformationMaintion());
            //Application.Run(new DocManage.DocManageTool.DocManageTool());
            //Application.Run(new BPM.TestForm());

        }
    }
}