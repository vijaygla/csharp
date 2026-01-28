# Regex
- Regex is used to match, validate, search, and replace text patterns.


## 🔸 Common Uses
- Email validation
- Phone number validation
- Password rules
- Search patterns

> Email validation
```csharp
using System.Text.RegularExpressions;

public bool IsValidEmail(string email)
{
    string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
    return Regex.IsMatch(email, pattern);
}
```
