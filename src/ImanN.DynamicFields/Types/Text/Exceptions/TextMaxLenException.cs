using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields;

public class TextMaxLenException : DynamicFieldConstraintViolationException
{

    public TextMaxLenException(int maxLen) 
        : base(message: $"The maximum length for this Field is : {maxLen}")
    {
    }
}