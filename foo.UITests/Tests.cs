using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace foo.UITests
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			app = ConfigureApp.Android.StartApp();
		}

		[Test]
		public void AppDidLaunch()
		{
			app.WaitForElement(c => c.Id("fab"));
			app.Tap(c => c.Id("fab"));
			Assert.AreNotEqual("ERROR!", app.Query(c => c.Id("textView1"))[0].Text);
			app.Screenshot("App launched");
		}
	}
}
