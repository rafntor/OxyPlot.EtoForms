using Eto.Drawing;
using Eto.Forms;

namespace TestApp
{
	partial class MainForm : Form
	{
		void InitializeComponent()
		{
			Title = "My Eto Form";
			MinimumSize = new Size(200, 200);
			Size = new Size(800, 600);
			Padding = 10;

			Content = new Label() { Text = "Click Me!", Font = Fonts.Sans(20),
				TextAlignment = TextAlignment.Center, VerticalAlignment = VerticalAlignment.Center	};

			// create a few commands that can be used for the menu and toolbar
			var clickMe = new Command { MenuText = "Click Me!", ToolBarText = "Click Me!" };
			clickMe.Executed += (sender, e) => MessageBox.Show(this, "I was clicked!");

			var quitCommand = new Command { MenuText = "Quit", Shortcut = Application.Instance.CommonModifier | Keys.Q };
			quitCommand.Executed += (sender, e) => Application.Instance.Quit();

			var aboutCommand = new Command { MenuText = "About..." };
			aboutCommand.Executed += (sender, e) => new AboutDialog().ShowDialog(this);

			// create menu
			Menu = new MenuBar
			{
				Items =
				{
					// File submenu
//					new SubMenuItem { Text = "&File", Items = { clickMe } },
					// new SubMenuItem { Text = "&Edit", Items = { /* commands/items */ } },
					// new SubMenuItem { Text = "&View", Items = { /* commands/items */ } },
				},
				ApplicationItems =
				{
					// application (OS X) or file menu (others)
//					new ButtonMenuItem { Text = "&Preferences..." },
				},
				QuitItem = quitCommand,
				AboutItem = aboutCommand
			};

			// create toolbar			
			//			ToolBar = new ToolBar { Items = { clickMe } };
		}
	}
}
