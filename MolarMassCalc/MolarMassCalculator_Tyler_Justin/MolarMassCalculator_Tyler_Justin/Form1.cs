using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MolarMassCalculator_Tyler_Justin
{
    public partial class Form1 : Form
    {
        public List<Element> elements;
        List<Regex> symbols;
        List<Regex> names;
        public Form1()
        {
            InitializeComponent();

            symbols = new List<Regex>();
            names = new List<Regex>();

            elements = new List<Element>
            {
                //new Element("Hydrogen", "H", 1, Math.Round(1.008, 4)),
                //new Element("Helium", "He", 2, Math.Round(4.0026, 4)),
                //new Element("Lithium", "Li", 3, Math.Round(6.94, 4)),
                //new Element("Beryllium", "Be", 4, Math.Round(9.0122, 4)),
                //new Element("Boron", "B", 5, Math.Round(10.81, 4)),
                //new Element("Carbon", "C", 6, Math.Round(12.011, 4)),
                //new Element("Nitrogen", "N", 7, Math.Round(14.007, 4)),
                //new Element("Oxygen", "O", 8, Math.Round(15.999, 4)),
                //new Element("Fluorine", "F", 9, Math.Round(18.998, 4)),
                //new Element("Neon", "Ne", 10, Math.Round(20.180, 4)),
                //new Element("Sodium", "Na", 11, Math.Round(22.990, 4)),
                //new Element("Magnesium", "Mg", 12, Math.Round(24.305, 4)),
                //new Element("Aluminum", "Al", 13, Math.Round(26.982, 4)),
                //new Element("Silicon", "Si", 14, Math.Round(28.085, 4)),
                //new Element("Phosphorus", "P", 15, Math.Round(30.974, 4)),
                //new Element("Sulfur", "S", 16, Math.Round(32.06, 4)),
                //new Element("Chlorine", "Cl", 17, Math.Round(35.45, 4)),
                //new Element("Argon", "Ar", 18, Math.Round(39.948, 4)),
                //new Element("Potassium", "K", 19, Math.Round(39.098, 4)),
                //new Element("Calcium", "Ca", 20, Math.Round(40.078, 4)),
                //new Element("Scandium", "Sc", 21, Math.Round(44.956, 4)),
                //new Element("Titanium", "Ti", 22, Math.Round(47.867, 4)),
                //new Element("Vanadium", "V", 23, Math.Round(50.941, 4)),
                //new Element("Chromium", "Cr", 24, Math.Round(51.996, 4)),
                //new Element("Manganese", "Mn", 25, Math.Round(54.938, 4)),
                //new Element("Iron", "Fe", 26, Math.Round(55.845, 4)),
                //new Element("Cobalt", "Co", 27, Math.Round(58.933, 4)),
                //new Element("Nickel", "Ni", 28, Math.Round(58.693, 4)),
                //new Element("Copper", "Cu", 29, Math.Round(63.546, 4)),
                //new Element("Zinc", "Zn", 30, Math.Round(65.38, 4)),
                //new Element("Gallium", "Ga", 31, Math.Round(69.723, 4)),
                //new Element("Germanium", "Ge", 32, Math.Round(72.630, 4)),
                //new Element("Arsenic", "As", 33, Math.Round(74.922, 4)),
                //new Element("Selenium", "Se", 34, Math.Round(78.971, 4)),
                //new Element("Bromine", "Br", 35, Math.Round(79.904, 4)),
                //new Element("Krypton", "Kr", 36, Math.Round(83.798, 4)),
                //new Element("Rubidium", "Rb", 37, Math.Round(85.468, 4)),
                //new Element("Strontium", "Sr", 38, Math.Round(87.62, 4)),
                //new Element("Yttrium", "Y", 39, Math.Round(88.906, 4)),
                //new Element("Zirconium", "Zr", 40, Math.Round(91.224, 4)),
                //new Element("Niobium", "Nb", 41, Math.Round(92.906, 4)),
                //new Element("Molybdenum", "Mo", 42, Math.Round(95.95, 4)),
                //new Element("Technetium", "Tc", 43, Math.Round(98.0, 4)),
                //new Element("Ruthenium", "Ru", 44, Math.Round(101.07, 4)),
                //new Element("Rhodium", "Rh", 45, Math.Round(102.91, 4)),
                //new Element("Palladium", "Pd", 46, Math.Round(106.42, 4)),
                //new Element("Silver", "Ag", 47, Math.Round(107.87, 4)),
                //new Element("Cadmium", "Cd", 48, Math.Round(112.41, 4)),
                //new Element("Indium", "In", 49, Math.Round(114.82, 4)),
                //new Element("Tin", "Sn", 50, Math.Round(118.71, 4)),
                //new Element("Antimony", "Sb", 51, Math.Round(121.76, 4)),
                //new Element("Tellurium", "Te", 52, Math.Round(127.60, 4)),
                //new Element("Iodine", "I", 53, Math.Round(126.90, 4)),
                //new Element("Xenon", "Xe", 54, Math.Round(131.29, 4)),
                //new Element("Cesium", "Cs", 55, Math.Round(132.91, 4)),
                //new Element("Barium", "Ba", 56, Math.Round(137.33, 4)),
                //new Element("Lanthanum", "La", 57, Math.Round(138.91, 4)),
                //new Element("Cerium", "Ce", 58, Math.Round(140.12, 4)),
                //new Element("Praseodymium", "Pr", 59, Math.Round(140.91, 4)),
                //new Element("Neodymium", "Nd", 60, Math.Round(144.24, 4)),
                //new Element("Promethium", "Pm", 61, Math.Round(145.0, 4)),
                //new Element("Samarium", "Sm", 62, Math.Round(150.36, 4)),
                //new Element("Europium", "Eu", 63, Math.Round(151.96, 4)),
                //new Element("Gadolinium", "Gd", 64, Math.Round(157.25, 4)),
                //new Element("Terbium", "Tb", 65, Math.Round(158.93, 4)),
                //new Element("Dysprosium", "Dy", 66, Math.Round(162.50, 4)),
                //new Element("Holmium", "Ho", 67, Math.Round(164.93, 4)),
                //new Element("Erbium", "Er", 68, Math.Round(167.26, 4)),
                //new Element("Thulium", "Tm", 69, Math.Round(168.93, 4)),
                //new Element("Ytterbium", "Yb", 70, Math.Round(173.04, 4)),
                //new Element("Lutetium", "Lu", 71, Math.Round(174.97, 4)),
                //new Element("Hafnium", "Hf", 72, Math.Round(178.49, 4)),
                //new Element("Tantalum", "Ta", 73, Math.Round(180.95, 4)),
                //new Element("Tungsten", "W", 74, Math.Round(183.84, 4)),
                //new Element("Rhenium", "Re", 75, Math.Round(186.21, 4)),
                //new Element("Osmium", "Os", 76, Math.Round(190.23, 4)),
                //new Element("Iridium", "Ir", 77, Math.Round(192.22, 4)),
                //new Element("Platinum", "Pt", 78, Math.Round(195.08, 4)),
                //new Element("Gold", "Au", 79, Math.Round(196.97, 4)),
                //new Element("Mercury", "Hg", 80, Math.Round(200.59, 4)),
                //new Element("Thallium", "Tl", 81, Math.Round(204.38, 4)),
                //new Element("Lead", "Pb", 82, Math.Round(207.2, 4)),
                //new Element("Bismuth", "Bi", 83, Math.Round(208.98, 4)),
                //new Element("Polonium", "Po", 84, Math.Round(209.0, 4)),
                //new Element("Astatine", "At", 85, Math.Round(210.0, 4)),
                //new Element("Radon", "Rn", 86, Math.Round(222.0, 4)),
                //new Element("Francium", "Fr", 87, Math.Round(223.0, 4)),
                //new Element("Radium", "Ra", 88, Math.Round(226.0, 4)),
                //new Element("Actinium", "Ac", 89, Math.Round(227.0, 4)),
                //new Element("Thorium", "Th", 90, Math.Round(232.04, 4)),
                //new Element("Protactinium", "Pa", 91, Math.Round(231.04, 4)),
                //new Element("Uranium", "U", 92, Math.Round(238.03, 4)),
                //new Element("Neptunium", "Np", 93, Math.Round(237.0, 4)),
                //new Element("Plutonium", "Pu", 94, Math.Round(244.0, 4)),
                //new Element("Americium", "Am", 95, Math.Round(243.0, 4)),
                //new Element("Curium", "Cm", 96, Math.Round(247.0, 4)),
                //new Element("Berkelium", "Bk", 97, Math.Round(247.0, 4)),
                //new Element("Californium", "Cf", 98, Math.Round(251.0, 4)),
                //new Element("Einsteinium", "Es", 99, Math.Round(252.0, 4)),
                //new Element("Fermium", "Fm", 100, Math.Round(257.0, 4)),
                //new Element("Mendelevium", "Md", 101, Math.Round(258.0, 4)),
                //new Element("Nobelium", "No", 102, Math.Round(259.0, 4)),
                //new Element("Lawrencium", "Lr", 103, Math.Round(262.0, 4)),
                //new Element("Rutherfordium", "Rf", 104, Math.Round(267.0, 4)),
                //new Element("Dubnium", "Db", 105, Math.Round(270.0, 4)),
                //new Element("Seaborgium", "Sg", 106, Math.Round(271.0, 4)),
                //new Element("Bohrium", "Bh", 107, Math.Round(270.0, 4)),
                //new Element("Hassium", "Hs", 108, Math.Round(277.0, 4)),
                //new Element("Meitnerium", "Mt", 109, Math.Round(276.0, 4)),
                //new Element("Darmstadtium", "Ds", 110, Math.Round(281.0, 4)),
                //new Element("Roentgenium", "Rg", 111, Math.Round(280.0, 4)),
                //new Element("Copernicium", "Cn", 112, Math.Round(285.0, 4)),
                //new Element("Nihonium", "Nh", 113, Math.Round(286.0, 4)),
                //new Element("Flerovium", "Fl", 114, Math.Round(289.0, 4)),
                //new Element("Moscovium", "Mc", 115, Math.Round(288.0, 4)),
                //new Element("Livermorium", "Lv", 116, Math.Round(292.0, 4)),
                //new Element("Tennessine", "Ts", 117, Math.Round(294.0, 4)),
                //new Element("Oganesson", "Og", 118, Math.Round(294.0, 4))
            };
            
        }

        BindingSource bindingSource = new BindingSource();

        private void Form1_Load(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;

            // Define the file path for the input data
            string filePath = projectDirectory + "\\message-2.txt";


            try
            {
                // Open the file for reading
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read the entire file content as a string
                    var lines = reader.ReadToEnd();

                    // Split the content into lines and remove any empty lines
                    var linesList = lines.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Where(line => !string.IsNullOrWhiteSpace(line))
                                         .ToList();

                    // Iterate through each line in the list
                    foreach (var line in linesList)
                    {
                        // Split the line by commas to get individual parts
                        var parts = line.Split(',');

                        // Check if the line has exactly 4 parts
                        if (parts.Length == 4)
                        {
                            // Parse the atomic number from the first part
                            int anum = int.Parse(parts[0]); // Atomic number

                            // Assign the second part to the symbol
                            string sym = parts[1];          // Symbol

                            // Assign the third part to the name
                            string name = parts[2];         // Name

                            // Parse the mass from the fourth part
                            double mass = double.Parse(parts[3]); // Mass

                            // Create a new Element object and add it to the elements list
                            elements.Add(new Element(anum, sym, name, mass));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during file reading or parsing
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            //SetupDataGridView();

            InsertInfo();
        }

        private void InsertInfo()
        {
            var elementData = from element in elements
                              select new
                              {
                                  AtomicNumber = element.atomicNumber,
                                  Name = element.name,
                                  Symbol = element.symbol,
                                  AtomicMass = element.atomicMass
                              };

            // Bind the data to the DataGridView using BindingSource
            bindingSource.DataSource = elementData.ToList();
            dataGridView.DataSource = bindingSource;
        }

        private void SetupDataGridView()
        {
            // Add columns
            dataGridView.ColumnCount = 4;

            dataGridView.Columns[0].Name = "Atomic Number";
            dataGridView.Columns[1].Name = "Name";
            dataGridView.Columns[2].Name = "Symbol";
            dataGridView.Columns[3].Name = "Mass";

            // Optional: Set column widths
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Width = 140; // Set all columns to a width of 100
            }
        }

        private void txt_chemicalformual_TextChanged(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            string search = txt_chemicalformual.Text.ToLower();

            //var sortedElements = elements.OrderByDescending(el => el.symbol.Length).ToList();

            //Sorted elements consisting of elements ordered by symbol length
            var sortedElements = from element in elements
                                 orderby element.symbol.Length descending
                                 select element;

            //List of invalid symbols
            var invalidSymbols = new HashSet<string>();

            txtInvalidSymbols.Clear();

            int index = 0;
            double totalmassOfAll = 0;

            var resultData = new List<object>();

            //While index is less than formula length
            while (index < search.Length)
            {
                bool matched = false;

                // Try matching each element's symbol with a case-insensitive regex
                foreach (var element in sortedElements)
                {
                    string pattern = "^" + Regex.Escape(element.symbol); // Escape symbols like "+" and match only at the start
                    Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

                    // Check if the current part of the formula matches an element's symbol
                    var match = regex.Match(search.Substring(index));

                    if (match.Success)
                    {
                        matched = true;
                        int symbolLength = match.Length;
                        int count = 1;

                        // Check if there's a digit after the symbol
                        if (index + symbolLength < search.Length && char.IsDigit(search[index + symbolLength]))
                        {
                            string number = new string(search.Skip(index + symbolLength).TakeWhile(c => char.IsDigit(c)).ToArray());
                            count = int.Parse(number);
                            index += symbolLength + number.Length; // Move past the symbol and the digits
                        }
                        else
                        {
                            index += symbolLength; // Move past the symbol only
                        }

                        // Calculate the total mass for this element
                        double totalMass = count * element.atomicMass;
                        totalmassOfAll += totalMass;

                        resultData.Add(new
                        {
                            Name = element.name,
                            Count = count,
                            AtomicMass = element.atomicMass,
                            TotalMass = totalMass
                        });
                        break;
                    }
                }

                if (!matched)
                {
                    // Handle invalid symbols
                    string invalidSymbol = search.Substring(index, 1);
                    if (!invalidSymbols.Contains(invalidSymbol) && !char.IsDigit(invalidSymbol[0]))
                    {
                        invalidSymbols.Add(invalidSymbol.ToUpper());
                    }
                    index++;
                }
            }


            bindingSource.DataSource = resultData.ToList();
            //display all values to the UI
            txt_molarmass.Text = $"{totalmassOfAll:F4} g/mol";
            txt_molarmass.BackColor = txt_molarmass.BackColor;
            txt_molarmass.ForeColor = Color.Green;

            if (invalidSymbols.Count > 0)
            {
                foreach(var item in invalidSymbols)
                {
                    txtInvalidSymbols.Text += ", " + item.ToString();
                }
            }

        }

        private void btn_sortbyname_Click(object sender, EventArgs e)
        {

            // Clear any existing rows in the DataGridView
            dataGridView.Rows.Clear();

            // Use LINQ to sort the elements by name
            var sortedElements = from element in elements
                                 orderby element.name // Order by the name property
                                 select new
                                 {
                                     AtomicNum = element.atomicNumber, // Select atomic number
                                     Name = element.name,              // Select name
                                     AtomicMass = element.atomicMass,   // Select atomic mass
                                     Symbol = element.symbol           // Select symbol
                                 };

            bindingSource.DataSource = sortedElements;
        }

        private void btn_scs_Click(object sender, EventArgs e)
        {
            // Clear any existing rows in the DataGridView
            dataGridView.Rows.Clear();

            var sortedElements = from element in elements
                                 orderby element.symbol.Length, element.symbol // Order by the name property
                                 select new
                                 {
                                     AtomicNum = element.atomicNumber, // Select atomic number
                                     Name = element.name,              // Select name
                                     AtomicMass = element.atomicMass,   // Select atomic mass
                                     Symbol = element.symbol           // Select symbol
                                 };

            bindingSource.DataSource = sortedElements;
        }

        private void btn_sortbyatomicnum_Click(object sender, EventArgs e)
        {
            // Clear any existing rows in the DataGridView
            dataGridView.Rows.Clear();

            // Use LINQ to sort the elements by atomic number
            var sortedElements = from element in elements
                                 orderby element.atomicNumber // Order by the atomic number property
                                 select new
                                 {
                                     AtomicNum = element.atomicNumber, // Select atomic number
                                     Name = element.name,              // Select name
                                     AtomicMass = element.atomicMass,   // Select atomic mass
                                     Symbol = element.symbol           // Select symbol
                                 };

            bindingSource.DataSource = sortedElements;
        }

        private void txt_searchtextbox_TextChanged(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            string input = txt_searchtextbox.Text;

            var result = new List<Element>();

            //If string is empty return default list
            if(string.IsNullOrEmpty(input))
            {
                result = elements;
            }
            //checks if input is a decimal number
            else if(Regex.IsMatch(input, @"^\d+\.\d+$"))
            {
                result = SearchByAtomicMass(input);
            }
            //checks if input is an integer
            else if(Regex.IsMatch(input, @"^\d+$"))
            {
                result = SearchByAtomicNum(input);
            }
            //else search by name and symbol and return them to list prioritizing symbol
            else
            {
                var nameMatch = SearchByName(input);
                var symbolMatch = SearchBySymbol(input);

                result = symbolMatch.Concat(nameMatch).Distinct().ToList();
            }

            //puts everything back into the list
            var result2 = result.Concat(elements).Distinct().ToList();

            var displayData = result2.Select(element => new
            {
                AtomicNumber = element.atomicNumber,
                Name = element.name,
                Symbol = element.symbol,
                Mass = element.atomicMass
            }).ToList();

            bindingSource.DataSource = displayData;


        }

        public List<Element> SearchByName(string input)
        {
            //Sets regex pattern to the input, case insensitive
            Regex reg = new Regex(input, RegexOptions.IgnoreCase);

            //returns the elements that match the element name
            var results = from element in elements
                                    where reg.IsMatch(element.name)
                                    select element;

            return results.ToList();
        }

        public List<Element> SearchBySymbol(string input)
        {
            //Sets regex pattern to the input, case insensitive
            Regex reg = new Regex(input, RegexOptions.IgnoreCase);

            //var results = from element in elements
            //              where reg.IsMatch(element.symbol)
            //              select element;

            //return results.ToList();

            //returns the elements that match the exact element symbol
            var exactMatch = from element in elements
                             where element.symbol.Equals(input, StringComparison.OrdinalIgnoreCase)
                             select element;

            //returns the elements that partially match the element symbol
            var partialMatch = from element in elements
                               where reg.IsMatch(element.symbol) && !exactMatch.Contains(element)
                               orderby element.symbol
                               select element;

            //prioritize exact matches
            return exactMatch.Concat(partialMatch).Distinct().ToList();
        }

        public List<Element> SearchByAtomicNum(string input)
        {
            //Sets regex pattern to the input, case insensitive
            Regex reg = new Regex(input, RegexOptions.IgnoreCase);

            //returns the elements that match the atomic number
            var results = from element in elements
                          where reg.IsMatch(element.atomicNumber.ToString())
                          select element;

            return results.ToList();
        }

        public List<Element> SearchByAtomicMass(string input)
        {
            //Parse input into a double
            if(double.TryParse(input, out double mass))
            {
                //return the elements within 5 of the inputted atomic mass
                var results = from element in elements
                               where element.atomicMass >= mass - 5 && element.atomicMass <= mass + 5
                               orderby Math.Abs(element.atomicMass - mass)
                              select element;

                return results.ToList();
            }

            return new List<Element>();
        }
    }
}
