using HRManagement.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRManagement
{
    public partial class Main : Form
    {
        List<Worker> workers = new List<Worker>();
        FileHelper<List<Worker>> _fileHelper = new FileHelper<List<Worker>>(Path.Combine(Environment.CurrentDirectory, "workers.txt"));

        public bool IsMaximized
        {
            get
            {
                return Settings.Default.IsMaximized;
            }
            set
            {
                Settings.Default.IsMaximized = value;
            }
        }

        public Main()
        {
            InitializeComponent();
            RefreshDiary();
            SetColumnsHeader();
            dgvDiary.Columns[nameof(Worker.IsDismissalDateExisting)].Visible = false;
            if (IsMaximized)
                WindowState = FormWindowState.Maximized;
            btnEditDismiss.Enabled = dgvDiary.SelectedRows.Count == 1;
            cobView.SelectedItem = "wszystkich";
            // Wybranie wyświetlenia wszystkich pracowników jako domyślnej opcji
        }
        private void DgvDiary_SelectionChanged(object sender, EventArgs e)
        {
            btnEditDismiss.Enabled = dgvDiary.SelectedRows.Count == 1;
        }
        private void RefreshDiary()
        {
            workers = _fileHelper.DeserializeFromFile();
            dgvDiary.DataSource = workers;
            EmployOrDismissWorkerIfDatePassed();
        }
        private void EmployOrDismissWorkerIfDatePassed()
        {
            foreach (Worker worker in workers)
            {
                if (worker != null)
                    if (worker.EmploymentDate == null)
                        if (worker.IsDismissalDateExisting == false) // Data zatrudnienia nieznana, data zwolnienia nie istnieje
                            worker.IsEmployed = true;
                        else if (worker.IsDismissalDateExisting == true && worker.DismissalDate != null) // Data zatrudnienia nieznana, data zwolnienia istnieje i jest znana
                            worker.IsEmployed = DateTime.Today < worker.DismissalDate;
                        else // Data zatrudnienia nieznana, data zwolnienia istnieje ale jest nieznana (już się wydarzyła)
                            worker.IsEmployed = false;
                    else if (DateTime.Today >= worker.EmploymentDate)
                        if (worker.IsDismissalDateExisting == true && worker.DismissalDate != null) // Istnieje i znana
                            worker.IsEmployed = DateTime.Today < worker.DismissalDate;
                        else if (worker.IsDismissalDateExisting == null) // Istnieje, ale nieznana (już się wydarzyła)
                            worker.IsEmployed = false;
                        else if (worker.IsDismissalDateExisting == false) // Nie istnieje
                            worker.IsEmployed = true;
                    else
                        worker.IsEmployed = false;
            }
        }

        private void SetColumnsHeader()
        {
            dgvDiary.Columns[nameof(Worker.Id)].HeaderText = "Numer";
            dgvDiary.Columns[nameof(Worker.FirstName)].HeaderText = "Imię";
            dgvDiary.Columns[nameof(Worker.LastName)].HeaderText = "Nazwisko";
            dgvDiary.Columns[nameof(Worker.EmploymentDate)].HeaderText = "Data zatrudnienia";
            dgvDiary.Columns[nameof(Worker.DismissalDate)].HeaderText = "Data zwolnienia";
            dgvDiary.Columns[nameof(Worker.Earnings)].HeaderText = "Zarobki";
            dgvDiary.Columns[nameof(Worker.Comments)].HeaderText = "Uwagi";
            dgvDiary.Columns[nameof(Worker.IsEmployed)].HeaderText = "Czy zatrudniony?";
        }

        private void AddEditWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshDiary();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                IsMaximized = true;
            else
                IsMaximized = false;
            Settings.Default.Save();
        }

        private void DgvDiary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = dgvDiary.Columns[e.ColumnIndex];
                if (column.Name == nameof(Worker.EmploymentDate))
                {
                    Worker worker = dgvDiary.Rows[e.RowIndex].DataBoundItem as Worker;
                    if (worker != null && worker.EmploymentDate == null)
                    {
                        e.Value = "Nieznana";
                        e.FormattingApplied = true;
                    }
                }
                else if (column.Name == nameof(Worker.DismissalDate))
                {
                    Worker worker = dgvDiary.Rows[e.RowIndex].DataBoundItem as Worker;
                    if (worker != null)
                    {
                        if (worker.IsDismissalDateExisting == false)
                        {
                            e.Value = "Brak";
                            e.FormattingApplied = true;
                        }
                        else if (worker.DismissalDate == null)
                        {
                            e.Value = "Nieznana";
                            e.FormattingApplied = true;
                        }
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EmployEditDismissWorker employEditDismissWorker = new EmployEditDismissWorker();
            employEditDismissWorker.FormClosing += AddEditWorker_FormClosing;
            employEditDismissWorker.ShowDialog();
        }

        private void BtnEditDismiss_Click(object sender, EventArgs e)
        {
            EmployEditDismissWorker employEditDismissWorker = new EmployEditDismissWorker(
                Convert.ToUInt32(dgvDiary.SelectedRows[0].Cells[0].Value));
            employEditDismissWorker.FormClosing += AddEditWorker_FormClosing;
            employEditDismissWorker.ShowDialog();

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDiary();
        }

        private void CobView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cobView.SelectedItem.ToString();
            switch (selectedOption)
            {
                case "wszystkich":
                    dgvDiary.DataSource = workers;
                    break;
                case "zatrudnionych":
                    dgvDiary.DataSource = workers.Where(w => w.IsEmployed).ToList();
                    break;
                case "zatrudnionych bez zaplanowanego zwolnienia":
                    dgvDiary.DataSource = workers.Where(w => w.IsEmployed && w.IsDismissalDateExisting==false).ToList();
                    break;
                case "zatrudnionych z zaplanowanym zwolnieniem":
                    dgvDiary.DataSource = workers.Where(w => w.IsEmployed && w.IsDismissalDateExisting==true).ToList();
                    break;
                case "niezatrudnionych":
                    dgvDiary.DataSource = workers.Where(w => w.IsEmployed==false).ToList();
                    break;
                case "niezatrudnionych z zaplanowanym zatrudnieniem":
                    dgvDiary.DataSource = workers.Where(w => w.IsEmployed == false && w.EmploymentDate>DateTime.Today).ToList();
                    break;
                case "zwolnionych":
                    dgvDiary.DataSource = workers.Where(w => w.IsEmployed == false && w.DismissalDate<=DateTime.Today).ToList();
                    break;
            }
        }

        private void CobView_MouseHover(object sender, EventArgs e)
        {
            ttCobDescription.Show("Opcja \"zatrudnionych\" wyświetla wszystkich zatrudnionych niezależnie od tego czy jest zaplanowane zwolnienie. \nOpcja \"niezatrudnionych\" wyświetla zarówno niezatrudnionych z zaplanowanym zatrudnieniem, jak i tych, u których data zwolnienia jest wcześniejsza od dzisiejszej daty lub równa dzisiejszej dacie.", this.cobView, 32767);
        }
    }
}
