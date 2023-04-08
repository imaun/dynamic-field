using ImanN.DynamicFields.Exceptions;

namespace ImanN.DynamicFields;

public class TextMinLenException : DynamicFieldConstraintViolationException
{

    public TextMinLenException(int minLen)
        : base(message: $"The minimum length for the field is : {minLen}")
    {
    }
}