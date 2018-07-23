using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    class Calculation {

        public string inputOne { get; set; }
        public string inputTwo { get; set; }
        public Operation operation { get; set; }
        public bool isInputOne { get; set; }

        public Calculation() {
            inputOne = "";
            inputTwo = "";
            operation = new Operation();
            isInputOne = true;
        }

    }
}
