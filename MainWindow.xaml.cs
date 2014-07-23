using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Web.Script.Serialization;
using FirstFloor.ModernUI.Windows.Controls;

                                                                     
namespace WinClient
{
		/// <summary>
		/// Interaction logic for MainWindow.xaml
		/// </summary>
		public partial class MainWindow : ModernWindow 
		{
				public MainWindow()
				{
						//InitializeComponent();

						/*WebRequest req = WebRequest.Create("http://localhost:3054/RestWCF.svc/GetDataTableJson");
						req.ContentType = "application/json";
						WebResponse resp = req.GetResponse();
						Stream stream = resp.GetResponseStream();
						StreamReader re = new StreamReader(stream);
						String json = re.ReadToEnd();
						json = "{\"WebItems\":" + json + "}";
						wrapper w = (wrapper)new JavaScriptSerializer().Deserialize(json, typeof(wrapper));
						*/
						List<string> items = new List<string>();
					

						items.Add("Item1");
						items.Add("item2");

						//itemsList.ItemsSource = items;// w.WebItems;
				}

				void ShowItem(object sender, SelectionChangedEventArgs args)
			{
					String lbi = ((sender as ListBox).SelectedItem as String);
					//ItemDetails.Document.Blocks.Clear();
					//ItemDetails.Document.Blocks.Add(new Paragraph(new Run(lbi)));
			}
		}

	public class WebItem
	{
			public String name { get; set; }
			public String author { get; set; }

			public String json { get; set; }
	}

	public class wrapper
	{
			public List<WebItem> WebItems { get; set; }
	}
}
