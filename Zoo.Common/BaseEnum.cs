namespace Zoo.Common
{
    public abstract class BaseEnum
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public BaseEnum(string code, string description)
        {
            this.Code = code;
            this.Description = description;
        }
    }
}
