using System;

namespace CSharp10Classlib.ExtendedPropertyPatterns;

record Order(Payment Payment, Customer Customer);
record Payment(Price Price, DateTime? PaymentDate = null);
record Price(string Currency, decimal Amount);
record Customer(string Name, string Group);