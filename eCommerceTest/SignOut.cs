﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace eCommerceTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SignOut recording.
    /// </summary>
    [TestModule("ef7927cc-3598-46b6-b053-d36639a7303d", ModuleType.Recording, 1)]
    public partial class SignOut : ITestModule
    {
        /// <summary>
        /// Holds an instance of the eCommerceTestRepository repository.
        /// </summary>
        public static eCommerceTestRepository repo = eCommerceTestRepository.Instance;

        static SignOut instance = new SignOut();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SignOut()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SignOut Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            // Move on hesabim button.
            Report.Log(ReportLevel.Info, "Mouse", "Move on hesabim button.\r\nMouse Left Move item 'ApplicationUnderTest.Hesabım' at 26;12.", repo.ApplicationUnderTest.HesabımInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Hesabım.MoveTo("26;12");
            Delay.Milliseconds(0);
            
            // Click cikis yap button.
            Report.Log(ReportLevel.Info, "Mouse", "Click cikis yap button.\r\nMouse Left Click item 'ApplicationUnderTest.CıkışYap' at 40;32.", repo.ApplicationUnderTest.CıkışYapInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.CıkışYap.Click("40;32");
            Delay.Milliseconds(0);
            
            // Wait for giris yap button appear.
            Report.Log(ReportLevel.Info, "Wait", "Wait for giris yap button appear.\r\nWaiting 10s to exist. Associated repository item: 'ApplicationUnderTest.GirişYap'", repo.ApplicationUnderTest.GirişYapInfo, new ActionTimeout(10000), new RecordItemIndex(2));
            repo.ApplicationUnderTest.GirişYapInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.GirişYap'.", repo.ApplicationUnderTest.GirişYapInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ApplicationUnderTest.GirişYapInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}