using System;

namespace Command.RealWorld
{
    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    public class CalculatorCommand : Command
    {
        private char @operator;
        private int operand;
        private Calculator calculator;

        // Constructor
        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this.calculator = calculator;
            this.@operator = @operator;
            this.operand = operand;
        }

        // Execute new command
        public override void Execute()
        {
            calculator.Operation(@operator, operand);
        }

        // Unexecute last command
        public override void UnExecute()
        {
            calculator.Operation(Undo(@operator), operand);
        }

        // Returns opposite operator for given operator
        private char Undo(char @operator)
        {
            return @operator switch
            {
                '+' => '-',
                '-' => '+',
                '*' => '/',
                '/' => '*',
                _ => throw new ArgumentException("@operator"),
            };
        }
    }
}
