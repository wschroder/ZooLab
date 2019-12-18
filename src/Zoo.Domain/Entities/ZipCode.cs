using Zoo.Common.Exceptions;

namespace Zoo.Domain.Entities
{
    public class ZipCode
    {
        public string Value { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value"></param>
        public ZipCode(string value)
        {
            bool isValid = false;
            string testValue = value.Replace("-", "");
            if (int.TryParse(testValue, out int numValue))
            {
                isValid = (numValue.ToString() == testValue);                
            }

            if (!isValid)
            {
                throw new ValidationException($"Invalid zipcode value: [{value}]");
            }
            this.Value = value;
        }
    }
}