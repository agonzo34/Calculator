using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    class Operation {

        public bool isAddition { get; set; }
        public bool isSubtraction { get; set; }
        public bool isMultiplication { get; set; }
        public bool isDivision { get; set; }

        public Operation() {
            isAddition = false;
            isSubtraction = false;
            isMultiplication = false;
            isDivision = false;
        }

        public void setAddition() {
            isAddition = true; isSubtraction = false; isMultiplication = false; isDivision = false;
        }

        public void setSubtraction() {
            isAddition = false; isSubtraction = true; isMultiplication = false; isDivision = false;
        }

        public void setMultiplication() {
            isAddition = false; isSubtraction = false; isMultiplication = true; isDivision = false;
        }

        public void setDivision() {
            isAddition = false; isSubtraction = false; isMultiplication = false; isDivision = true;
        }

    }
}
