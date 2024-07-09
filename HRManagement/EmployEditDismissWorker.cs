using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HRManagement
{
    public partial class EmployEditDismissWorker : Form
    {
        private uint _workerId;
        private Worker _worker;
        private bool _isEmploymentDateKnown = true;
        Worker worker = new Worker();
        private FileHelper<List<Worker>> _fileHelper =
            new FileHelper<List<Worker>>(Path.Combine(Environment.CurrentDirectory, "workers.txt"));
        public EmployEditDismissWorker(uint id = 0)
        {
            InitializeComponent();
            _workerId = id;
            GetWorkerData();
            tbFirstName.Select();
        }


        private void GetWorkerData()
        {
            if (_workerId != 0)
            {
                Text = "Edytowanie danych pracownika";
                List<Worker> workers = _fileHelper.DeserializeFromFile();
                _worker = workers.FirstOrDefault(x => x.Id == _workerId);
                if (_worker == null)
                    throw new Exception("Brak użytkownika o podanym Id");
                FillFields();
            }
        }

        private void FillFields()
        {
            tbFirstName.Text = _worker.FirstName;
            tbLastName.Text = _worker.LastName;

            if (_worker.EmploymentDate == null)
            {
                dtpEmploymentDate.Visible = false;
                btnRestoreEmploymentDate.Visible = true;
                btnUnknownEmploymentDate.Visible = false;
                tbUnknownEmploymentDate.Visible = true;
            }
            else
            {
                dtpEmploymentDate.Value = (DateTime)_worker.EmploymentDate;
            }

            if (_worker.IsDismissalDateExisting == false)
            {
                dtpDismissalDate.Visible = false;
                btnNoDismissalDate.Visible = false;
                btnUnknownDismissalDate.Visible = false;
                btnRestoreDismissalDate.Visible = true;
                tbNoOrUnknownDismissalDate.Text = "Brak";
                tbNoOrUnknownDismissalDate.Visible = true;
            }
            else if (_worker.DismissalDate == null)
            {
                dtpDismissalDate.Visible = false;
                btnNoDismissalDate.Visible = false;
                btnUnknownDismissalDate.Visible = false;
                btnRestoreDismissalDate.Visible = true;
                tbNoOrUnknownDismissalDate.Text = "Nieznana";
                tbNoOrUnknownDismissalDate.Visible = true;
            }
            else
            {
                dtpDismissalDate.Value = (DateTime)_worker.DismissalDate;
                dtpDismissalDate.Visible = true;
                btnNoDismissalDate.Visible = true;
                btnUnknownDismissalDate.Visible = true;
                btnRestoreDismissalDate.Visible = false;
                tbNoOrUnknownDismissalDate.Visible = false;
            }

            nudEarnings.Value = _worker.Earnings;
            rtbComments.Text = _worker.Comments;
        }


        private void AssignIdToNewWorker(List<Worker> workers)
        {
            Worker workerWithHighestId = workers
                .OrderByDescending(x => x.Id).FirstOrDefault();

            _workerId = workerWithHighestId == null ?
                1 : workerWithHighestId.Id + 1;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            List<Worker> workers = _fileHelper.DeserializeFromFile();

            if (_workerId != 0)
                workers.RemoveAll(x => x.Id == _workerId);
            else
                AssignIdToNewWorker(workers);

            worker.Id = _workerId;
            worker.FirstName = tbFirstName.Text;
            worker.LastName = tbLastName.Text;
            worker.EmploymentDate = _isEmploymentDateKnown ? (DateTime?)dtpEmploymentDate.Value.Date : null;
            worker.Earnings = (uint)nudEarnings.Value;
            worker.Comments = rtbComments.Text;

            if (tbNoOrUnknownDismissalDate.Visible && tbNoOrUnknownDismissalDate.Text == "Brak")
            {
                worker.IsDismissalDateExisting = false;
                worker.DismissalDate = null;
                worker.IsEmployed = true;
            }
            else if (tbNoOrUnknownDismissalDate.Visible && tbNoOrUnknownDismissalDate.Text == "Nieznana")
            {
                worker.IsDismissalDateExisting = null;
                worker.DismissalDate = null;
                worker.IsEmployed = false;
            }
            else
            {
                worker.IsDismissalDateExisting = true;
                worker.DismissalDate = dtpDismissalDate.Value.Date;
                worker.IsEmployed = dtpDismissalDate.Value.Date > DateTime.Now;
            }



            if (worker.EmploymentDate >= worker.DismissalDate)
            {
                MessageBox.Show("Data zwolnienia nie może być wcześniejsza niż data zatrudnienia ani taka sama jak data zatrudnienia");
                return;
            }

            if (dtpEmploymentDate.Value.Date >= DateTime.Today && worker.DismissalDate != null)
            {
                if (!(worker.EmploymentDate == null & worker.DismissalDate != null))
                {
                    if (!(worker.EmploymentDate != null & worker.DismissalDate != null))
                    {
                        MessageBox.Show("Nie można ustawić daty zwolnienia jako \"Nieznana\", bo data zatrudnienia nie jest wcześniejsza od dzisiejszej daty.");
                        MessageBox.Show("e" + worker.EmploymentDate + "d" + worker.DismissalDate);
                        return;
                    }
                }
            }
            btnConfirm.Enabled = false;
            workers.Add(worker);
            _fileHelper.SerializeToFile(workers);
            Close();
        }

        private void BtnUnknownEmploymentDate_Click(object sender, EventArgs e)
        {
            dtpEmploymentDate.Visible = false;
            tbUnknownEmploymentDate.Visible = true;
            btnRestoreEmploymentDate.Visible = true;
            _isEmploymentDateKnown = false;
            btnUnknownDismissalDate.Enabled = true;
        }

        private void BtnUnknownDismissalDate_Click(object sender, EventArgs e)
        {
            dtpDismissalDate.Visible = false;
            btnUnknownDismissalDate.Visible = false;
            btnNoDismissalDate.Visible = false;
            tbNoOrUnknownDismissalDate.Text = "Nieznana";
            tbNoOrUnknownDismissalDate.Visible = true;
            btnRestoreDismissalDate.Visible = true;
            worker.IsDismissalDateExisting = null;
            worker.IsEmployed = false;
        }

        private void BtnNoDismissalDate_Click(object sender, EventArgs e)
        {
            dtpDismissalDate.Visible = false;
            btnUnknownDismissalDate.Visible = false;
            btnNoDismissalDate.Visible = false;
            tbNoOrUnknownDismissalDate.Text = "Brak";
            tbNoOrUnknownDismissalDate.Visible = true;
            btnRestoreDismissalDate.Visible = true;
            worker.DismissalDate = null;
            worker.IsDismissalDateExisting = false;
        }

        private void BtnRestoreEmploymentDate_Click(object sender, EventArgs e)
        {
            tbUnknownEmploymentDate.Visible = false;
            btnRestoreEmploymentDate.Visible = false;
            dtpEmploymentDate.Visible = true;
            btnUnknownEmploymentDate.Visible = true;
            _isEmploymentDateKnown = true;
        }

        private void BtnRestoreDismissalDate_Click(object sender, EventArgs e)
        {
            tbNoOrUnknownDismissalDate.Visible = false;
            btnRestoreDismissalDate.Visible = false;
            dtpDismissalDate.Visible = true;
            btnNoDismissalDate.Visible = true;
            worker.IsDismissalDateExisting = true;
            btnUnknownDismissalDate.Visible = true;
            DisableBtnUnknownDismissalDateIfNotEarlierThanToday();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void TbLastName_TextChanged(object sender, EventArgs e)
        {
            tbLastName.Text = RemoveInvalidCharacters(tbLastName.Text);
            tbLastName.SelectionStart = tbLastName.Text.Length;
        }
        private string RemoveInvalidCharacters(string text)
        {
            return new string(text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == '-' || c == '\'' || c == '.' || c == '/').ToArray());
        }
        private void DisableBtnUnknownDismissalDateIfNotEarlierThanToday()
        {
            if (dtpEmploymentDate.Value.Date < DateTime.Today || btnRestoreEmploymentDate.Visible == true)
                btnUnknownDismissalDate.Enabled = true;
            else
                btnUnknownDismissalDate.Enabled = false;
        }
        private void DtpEmploymentDate_ValueChanged(object sender, EventArgs e)
        {
            DisableBtnUnknownDismissalDateIfNotEarlierThanToday();
        }
    }
}

