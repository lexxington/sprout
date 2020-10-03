Implementation details:

Technology stack:
* .Net Core 2.2
* Swagger for API demonstration
* xUnit for unit tests

Object model:
BaseFactory encapsulates of letter H production (as interface ILetter). 
Custom1Factory and Custom2Factory override some specific cases based on rule set.
ILetter is implemented for classes LetterM, LetterP, LetterT and Custom1LetterP, Custom2LetterM for different algorithm of K generation.
Case [other] => [error] is implemented as NotSupportedCaseException generation.

Unit Testing:
There is one base test's class named as AbstractTests. It is abstract and it implements common cases for Output quality control.
BaseTests, Custom1Tests and Custom2Tests are inherited from AbstractTests.
They additionally test special cases as base rules extention/overriding.