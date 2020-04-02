namespace LibrarieEntitati
{
    public class Student
    {
        // date membre private
        string nume;
        int[] note;

        // contructor implicit
        public Student()
        {
        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;
        }

        public void SetNote(string sirNote)
        {
            // initializare vector cu note
            note = new int[] { 1, 5, 3, 2, 4, -5 };
            // DE IMPLEMENTAT:
            // extrage note din sir si adauga in vectorul note

        }
        public string ConversieLaSir()
        {
            string sNote = "Nu exista (Nu ati apelat metoda **setNote**)";
            if (note != null)
            {
                sNote = string.Join(",", note);
            }
            string s = string.Format("Studentul {0} are notele:.... {1}", nume, sNote);

            return s;
        }
    }
}
