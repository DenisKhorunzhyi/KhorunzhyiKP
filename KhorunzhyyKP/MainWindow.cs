using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KhorunzhyyKP
{
    public partial class MainWindow : Form
    {
        private List<GraphClient> Graph = new List<GraphClient>();
        private ContextMenuStrip ContexMenu = new ContextMenuStrip();
        public MainWindow(){
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e){
            ShowIcon = false;

            openFileDialog.Title = "Оберіть файл із даними про графи";
            openFileDialog.Filter = "Text documents (.txt)|*.txt";

            Graph.Add(new GraphClient(panel1));
            Graph.Add(new GraphClient(panel2));

            ToolStripMenuItem CopyTextGraph = new ToolStripMenuItem("Копіювати в Clipboard");
            ToolStripMenuItem SaveImageGraph = new ToolStripMenuItem("Зберегти зображення");

            ContexMenu.Items.AddRange(new[] { CopyTextGraph, SaveImageGraph });

            panel1.ContextMenuStrip = panel2.ContextMenuStrip = ContexMenu;
            SaveImageGraph.Click += SaveImageGraph_Click;
            CopyTextGraph.Click += CopyTextGraph_Click;
        }

        

        #region Export\import
        private void Export_Click(object sender, EventArgs e) {
            Save();
        }
        private void Import_Click(object sender, EventArgs e) {
            Download();
        }
        private void Save(){
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Введіть назву файлу для збереження графів у форматі FI";
            saveFileDialog.FileName = "Graphs";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text documents (.txt)|*.txt";

            if (Graph[0].FI != null && Graph[1].FI != null){
                try {
                    string filename = "";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        filename = saveFileDialog.FileName;
                    string textForSaving = String.Join(" ", Graph[0].FI.FI) + "\n" +
                                           String.Join(" ", Graph[1].FI.FI);

                    File.WriteAllText(filename, textForSaving);
                    MessageBox.Show("Файл з назвою " + filename + " успішно збережено");
                }
                catch{
                    MessageBox.Show("Несподівана помилка!");
                    return;
                }
            }
            else{
                MessageBox.Show("Заповніть обидва графи");
                return;
            }
        }
        private void Download(){
            try {
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    string[] FI = File.ReadAllLines(openFileDialog.FileName);
                    FI1.Text = FI[0];
                    FI1.Font = new Font(RichTextBox.DefaultFont, FontStyle.Regular);
                    FI2.Text = FI[1];
                    FI2.Font = new Font(RichTextBox.DefaultFont, FontStyle.Regular);
                }
            }
            catch{
                MessageBox.Show("Файл має лише одну строчку!");
            }
        }

        #endregion

        private void CompareGraphs_Click(object sender, EventArgs e) {
            if (Graph[0].FI != null && Graph[1].FI != null) {
                string g1 = (Graph[0].Biconnected) ? "двозв'язний" : "не двозв'язний";
                string g2 = (Graph[1].Biconnected) ? "двозв'язний" : "не двозв'язний";
                if (Graph[0].Biconnected == Graph[1].Biconnected)
                    Result.Text = "Обидва графи еквівалентні\nПерший граф " + g1 + 
                        "\nДругий граф " + g2;
                else
                    Result.Text = "Обидва графи не еквівалентні\nПерший граф " + g1 + 
                        "\nДругий граф " + g2;
            }
            else {
                MessageBox.Show("Заповніть обидва графи");
                return;
            }
        }

        private void CreateGraphs_Click(object sender, EventArgs e){
            try{
                if (FI1.Text.Equals("") && FI2.Text.Equals("")){
                    MessageBox.Show("Заповніть хочаб одне поле представлення графу");
                    return;
                }
                if (!FI1.Text.Equals(""))
                    Graph[0].CreateGraph(FI1.Text);
                if (!FI2.Text.Equals(""))
                    Graph[1].CreateGraph(FI2.Text);
                FI1.Text = FI2.Text = "";
            }
            catch{
                MessageBox.Show("Помилка при заданні графу");
                return;
            }
        }

        private void FI_MouseLeave(object sender, EventArgs e){
            RichTextBox text = (RichTextBox)sender;
            if (text.Text.Equals("")){
                if (text.Name.ToString().Equals("FI1") && Graph[0].FI != null)
                    FI1.Text = String.Join(" ", Graph[0].FI.FI);
                else if (text.Name.ToString().Equals("FI2") && Graph[1].FI != null)
                    FI2.Text = String.Join(" ", Graph[1].FI.FI);
                else return;
                Font font = new Font(RichTextBox.DefaultFont, FontStyle.Italic);
                text.Font = font;
                sender = text;
            }
        }
        
        private void FI_MouseEnter(object sender, EventArgs e){
            RichTextBox text = (RichTextBox)sender;
            if (text.Font.Italic){
                text.Text = "";
                Font font = new Font(RichTextBox.DefaultFont, FontStyle.Regular);
                text.Font = font;
                sender = text;
            }
        }

        #region Contex Menu
        private void CopyTextGraph_Click(object sender, EventArgs e){
            ToolStripMenuItem toolContext = sender as ToolStripMenuItem;
            ContextMenuStrip context = toolContext.Owner as ContextMenuStrip;
            PictureBox picture = context.SourceControl as PictureBox;
            string textGraph = "";
            if (picture.Name.Equals("panel1") && Graph[0].FI != null)
                textGraph = String.Join(" ", Graph[0].FI.FI);
            else if(picture.Name.Equals("panel2") && Graph[1].FI != null)
                textGraph = String.Join(" ", Graph[1].FI.FI);
            else
                return;
            Clipboard.SetText(textGraph);
        }

        private void SaveImageGraph_Click(object sender, EventArgs e) {
            try {
                ToolStripMenuItem toolContext = sender as ToolStripMenuItem;
                ContextMenuStrip context = toolContext.Owner as ContextMenuStrip;
                PictureBox picture = context.SourceControl as PictureBox;
                string fileName = "";
                if ((picture.Name.Equals("panel1") && Graph[0].FI != null) ||
                    (picture.Name.Equals("panel2") && Graph[1].FI != null)){
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Зберегти зображення як...";
                    sfd.OverwritePrompt = true;
                    sfd.CheckPathExists = true;
                    sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                    sfd.ShowHelp = true;
                    if (sfd.ShowDialog() == DialogResult.OK)
                        fileName = sfd.FileName;
                    picture.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                    return;
            }
            catch { }
        }
        #endregion

    }
}
