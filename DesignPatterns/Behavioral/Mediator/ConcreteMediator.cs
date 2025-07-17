namespace DesignPatterns.Behavioral.Mediator
{
    // Concrete Mediator that coordinates colleagues
    public class ConcreteMediator : IMediator
    {
        private ConcreteColleague1 _col1;
        private ConcreteColleague2 _col2;
        private ConcreteColleague3 _col3;

        public void SetColleagues(ConcreteColleague1 col1, ConcreteColleague2 col2, ConcreteColleague3 col3)
        {
            _col1 = col1;
            _col2 = col2;
            _col3 = col3;
        }

        public void Notify(Colleague sender, string eventCode)
        {
            if (sender == _col1 && eventCode == "DataChanged")
            {
                bool isValid = string.IsNullOrEmpty(_col1.Data);
                _col2.SetBoolData(isValid);
            }
            else if (sender == _col2 && eventCode == "BoolChanged")
            {
                if (_col2.Data)
                    _col3.SetIntData(Math.Abs(_col3.Data));
            }
            else if (sender == _col3 && eventCode == "IntChanged")
            {
                if (_col3.Data > 0)
                    _col1.SetData("Data is valid");
            }
        }
    }

}
