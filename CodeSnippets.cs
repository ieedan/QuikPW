//Uses QuikPW to generate a pincode with 12 characters then a password with 12 characters

using QuikPW;

var passwordGenerator = new PasswordGenerator(); // Instantiates password generator

Console.WriteLine(passwordGenerator.GeneratePin(12)); // Generates pin

Console.WriteLine(passwordGenerator.GeneratePassword(12)); // Generates password

/*

Output: // Example of output
446102281481
fes3$fcb%4!n

*/

using QuikPW;

var passwordGenerator = new PasswordGenerator(new List<char>() { '1','2'}); // Instantiates password generator but passes in list of characters for the generate password method

Console.WriteLine(passwordGenerator.GeneratePin(12)); 

Console.WriteLine(passwordGenerator.GeneratePassword(12));

/*

Output: // Example of output
650755483224
221221111211 // Output only has 0's and 1's because those were the only characters provided in the list

*/
