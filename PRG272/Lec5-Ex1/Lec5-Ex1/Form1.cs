namespace Lec5_Ex1
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person(
                textBoxName.Text,
                textBoxSurname.Text,
                textBoxJob.Text
                );
            people.Add(person);
            listView1.Items.Add(person.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\VMothie\Documents\prg271\PRG272\Lec5-Ex1\Lec5-Ex1\Lec5Txt.txt";

            Write writer = new Write(); //instantiate the Write class

            writer.SaveToFile(people, filepath); //calls method we created, taking the people list and the filepath as parameters
            MessageBox.Show("Data saved to file successfully.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\VMothie\Documents\prg271\PRG272\Lec5-Ex1\Lec5-Ex1\Lec5Txt.txt";

            Read reader = new Read();
            List<string> data = reader.ReadFromFile(filepath);

            listView1.Items.Clear();

            foreach (string line in data)
            {
                listView1.Items.Add(line);
            }

        }
    }
}
