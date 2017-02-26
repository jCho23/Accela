using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace Accela
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("learnMoreId");
			app.Screenshot("We Tapped on 'Learn More' Button");

			app.SwipeRightToLeft();
			app.Screenshot("Then we will swipe right");

			app.SwipeRightToLeft();
			app.Screenshot("And we will swipe right");

			app.SwipeRightToLeft();
			app.Screenshot("We will swipe right again");

			app.SwipeRightToLeft();
			app.Screenshot("Last time we will swipe right");

			app.Tap("buttonRight");
			app.Screenshot("Let's tap the 'Close' Button");

			app.Tap("buttonSignup");
			app.Screenshot("Tapped on 'Sign Up' Button");

			app.ScrollDown();
			Thread.Sleep(8000);

			app.ScrollDown();
			Thread.Sleep(8000);

			app.ScrollDown();
			Thread.Sleep(8000);

			app.ScrollDown();
			Thread.Sleep(8000);

			app.ScrollDown();
			Thread.Sleep(8000);

			app.ScrollDown();
			Thread.Sleep(8000);

			app.ScrollDown();
			Thread.Sleep(8000);

			app.ScrollDown();
			Thread.Sleep(8000);

			app.ScrollDown();
			Thread.Sleep(8000);
			app.Screenshot("We will scroll down to accept TOS");

			app.Tap("acceptTermBtnId");
			app.Screenshot("Let's confirm the TOC");

			app.Tap(x => x.Css("#LoginName"));
			app.Screenshot("Then we Tap the Name Text Field");

			app.EnterText("Kevin Durant");
			app.Screenshot("We entered our name, Kevin Durant");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap(x => x.Css("#Email"));
			app.Screenshot("We tapped on 'E-Mail' Text Field");

			app.EnterText("kdtrey1@rainbuckets.com");
			app.Screenshot("Then, we entered our e-mail");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap(x => x.Css("#Password"));
			app.Screenshot("We tapped on 'Password' Text Field");

			app.EnterText("Russel");
			app.Screenshot("We typed in our password, 'Russel'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap(x => x.Css("#ConfirmPassword"));
			app.Screenshot("We tapped on 'Confirm Password' Text Field");

			app.EnterText("Russel");
			app.Screenshot("Then, we confirmed our password");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			//app.Tap(x => x.Css("#btnSignUpUsingEmail"));
			//app.Tap(x => x.Css(".top30").Index(1));
		}

	}
}
