///////////////////////////////////////////////////////////////////////////////
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
    ///The SignIn recording.
    /// </summary>
    [TestModule("2a3ad9b9-2dc7-4176-8517-56f46857c2f1", ModuleType.Recording, 1)]
    public partial class SignIn : ITestModule
    {
        /// <summary>
        /// Holds an instance of the eCommerceTestRepository repository.
        /// </summary>
        public static eCommerceTestRepository repo = eCommerceTestRepository.Instance;

        static SignIn instance = new SignIn();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SignIn()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SignIn Instance
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

            // Click e-mail field.
            Report.Log(ReportLevel.Info, "Mouse", "Click e-mail field.\r\nMouse Left Click item 'HttpsWwwTrendyolComUyelikcbEqhttps.ComboBox' at 62;36.", repo.HttpsWwwTrendyolComUyelikcbEqhttps.ComboBoxInfo, new RecordItemIndex(0));
            repo.HttpsWwwTrendyolComUyelikcbEqhttps.ComboBox.Click("62;36");
            Delay.Milliseconds(0);
            
            // Type mail.
            Report.Log(ReportLevel.Info, "Keyboard", "Type mail.\r\nKey sequence 'ronwelltest@gmail.com' with focus on 'HttpsWwwTrendyolComUyelikcbEqhttps.ComboBox'.", repo.HttpsWwwTrendyolComUyelikcbEqhttps.ComboBoxInfo, new RecordItemIndex(1));
            repo.HttpsWwwTrendyolComUyelikcbEqhttps.ComboBox.PressKeys("ronwelltest@gmail.com");
            Delay.Milliseconds(0);
            
            // Click password field.
            Report.Log(ReportLevel.Info, "Mouse", "Click password field.\r\nMouse Left Click item 'HttpsWwwTrendyolComUyelikcbEqhttps.Text' at 88;36.", repo.HttpsWwwTrendyolComUyelikcbEqhttps.TextInfo, new RecordItemIndex(2));
            repo.HttpsWwwTrendyolComUyelikcbEqhttps.Text.Click("88;36");
            Delay.Milliseconds(0);
            
            // Type password.
            Report.Log(ReportLevel.Info, "Keyboard", "Type password.\r\nKey sequence '●●●●●●●●●●●●' with focus on 'HttpsWwwTrendyolComUyelikcbEqhttps.Text'.", repo.HttpsWwwTrendyolComUyelikcbEqhttps.TextInfo, new RecordItemIndex(3));
            repo.HttpsWwwTrendyolComUyelikcbEqhttps.Text.PressKeys("testsifre123");
            Delay.Milliseconds(0);
            
            // Click submit button.
            Report.Log(ReportLevel.Info, "Mouse", "Click submit button.\r\nMouse Left Click item 'HttpsWwwTrendyolComUyelikcbEqhttps.GİRİŞYAP' at 222;26.", repo.HttpsWwwTrendyolComUyelikcbEqhttps.GİRİŞYAPInfo, new RecordItemIndex(4));
            repo.HttpsWwwTrendyolComUyelikcbEqhttps.GİRİŞYAP.Click("222;26");
            Delay.Milliseconds(0);
            
            // Wait for hesabim
            Report.Log(ReportLevel.Info, "Wait", "Wait for hesabim\r\nWaiting 10s to exist. Associated repository item: 'ApplicationUnderTest.Hesabım'", repo.ApplicationUnderTest.HesabımInfo, new ActionTimeout(10000), new RecordItemIndex(5));
            repo.ApplicationUnderTest.HesabımInfo.WaitForExists(10000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
