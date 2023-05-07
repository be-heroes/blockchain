using BeHeroes.Blockchainification.Core.Cryptography;

// See https://aka.ms/new-console-template for more information
var keyPair1 = new Ed25519KeyPair();

Console.WriteLine(keyPair1.Algorithm.Identifier);
Console.WriteLine(keyPair1.Private.ToString());
Console.WriteLine(keyPair1.Private.KeySize);
Console.WriteLine(keyPair1.Public.ToString());
Console.WriteLine(keyPair1.Public.KeySize);


var keyPair2 = new Secp256k1KeyPair();

Console.WriteLine(keyPair2.Algorithm.Identifier);
Console.WriteLine(keyPair2.Private.ToString());
Console.WriteLine(keyPair2.Private.KeySize);
Console.WriteLine(keyPair2.Public.ToString());
Console.WriteLine(keyPair2.Private.KeySize);