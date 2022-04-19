namespace raid_counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var keyboardHookManager = new KeyboardHookManager();
            keyboardHookManager.Start();


            keyboardHookManager.RegisterHotkey((int)VirtualKeys.Numpad7, () =>
            {
                rocket_up_down.Invoke((MethodInvoker)delegate
                {
                    rocket_up_down.Value++;
                });
            });

            keyboardHookManager.RegisterHotkey((int)VirtualKeys.Numpad4, () =>
            {
                rocket_up_down.Invoke((MethodInvoker)delegate
                {
                    rocket_up_down.Value--;
                });
            });


            keyboardHookManager.RegisterHotkey((int)VirtualKeys.Numpad9, () =>
            {
                c4_up_down.Invoke((MethodInvoker)delegate
                {
                    c4_up_down.Value++;
                });
            });

            keyboardHookManager.RegisterHotkey((int)VirtualKeys.Numpad6, () =>
            {
                c4_up_down.Invoke((MethodInvoker)delegate
                {
                    c4_up_down.Value--;
                });
            });


            keyboardHookManager.RegisterHotkey((int)VirtualKeys.Numpad1, () =>
            {
                c4_up_down.Invoke((MethodInvoker)delegate
                {
                    c4_up_down.Value = 0;
                });
                rocket_up_down.Invoke((MethodInvoker)delegate
                {
                    rocket_up_down.Value = 0;
                });
            });
        }
    }
}