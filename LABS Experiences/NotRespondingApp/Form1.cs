namespace NotRespondingApp;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
		timer.Tick += (o, e) =>
		{
			while (true)
			{
				var a = Math.Sqrt(Math.Abs(Math.Sin(DateTime.Now.Millisecond)));
				a *= 419489;
				a /= Math.PI;
				var b = 132465 + 4894 - a * a * a;
			}
		};
	}

	System.Windows.Forms.Timer timer = new() { Interval = 1000 };
	private void Form1_Load(object sender, EventArgs e)
	{
		timer.Start();
	}
}
