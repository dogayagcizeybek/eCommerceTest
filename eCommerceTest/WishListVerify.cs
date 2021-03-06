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
    ///The WishListVerify recording.
    /// </summary>
    [TestModule("8877c11f-8e57-4cce-a038-558ae4f1d2a3", ModuleType.Recording, 1)]
    public partial class WishListVerify : ITestModule
    {
        /// <summary>
        /// Holds an instance of the eCommerceTestRepository repository.
        /// </summary>
        public static eCommerceTestRepository repo = eCommerceTestRepository.Instance;

        static WishListVerify instance = new WishListVerify();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WishListVerify()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WishListVerify Instance
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

            // Click Senin icin sectik button.
            Report.Log(ReportLevel.Info, "Mouse", "Click Senin icin sectik button.\r\nMouse Left Click item 'ApplicationUnderTest.HttpsCdnDsmcdnComMnresize200200' at 64;52.", repo.ApplicationUnderTest.HttpsCdnDsmcdnComMnresize200200Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.HttpsCdnDsmcdnComMnresize200200.Click("64;52");
            Delay.Milliseconds(0);
            
            // Click favorite button.
            Report.Log(ReportLevel.Info, "Mouse", "Click favorite button.\r\nMouse Left Click item 'ApplicationUnderTest.FavoredProductContainer.FeaturedFv' at 10;52.", repo.ApplicationUnderTest.FavoredProductContainer.FeaturedFvInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.FavoredProductContainer.FeaturedFv.Click("10;52");
            Delay.Milliseconds(0);
            
            // Validate favorite button is checked.
            Report.Log(ReportLevel.Info, "Validation", "Validate favorite button is checked.\r\nValidating AttributeEqual (Class='i-heart-orange') on item 'ApplicationUnderTest.FavoredProductContainer.IHeartOrange'.", repo.ApplicationUnderTest.FavoredProductContainer.IHeartOrangeInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FavoredProductContainer.IHeartOrangeInfo, "Class", "i-heart-orange");
            Delay.Milliseconds(100);
            
            // Click favorite button.
            Report.Log(ReportLevel.Info, "Mouse", "Click favorite button.\r\nMouse Left Click item 'ApplicationUnderTest.FavoredProductContainer.FeaturedFv1' at 14;46.", repo.ApplicationUnderTest.FavoredProductContainer.FeaturedFv1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.FavoredProductContainer.FeaturedFv1.Click("14;46");
            Delay.Milliseconds(0);
            
            // Validate favorite button is checked.
            Report.Log(ReportLevel.Info, "Validation", "Validate favorite button is checked.\r\nValidating AttributeEqual (Class='i-heart-orange') on item 'ApplicationUnderTest.FavoredProductContainer.IHeartOrange1'.", repo.ApplicationUnderTest.FavoredProductContainer.IHeartOrange1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FavoredProductContainer.IHeartOrange1Info, "Class", "i-heart-orange");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
