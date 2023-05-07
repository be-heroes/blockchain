using System.Text;
using BeHeroes.Blockchainification.Core.Cryptography;
using BeHeroes.CodeOps.Abstractions.Strings;

var keyPair1 = new Ed25519KeyPair();

Console.WriteLine("Keypair1 output");
Console.WriteLine(keyPair1.Algorithm.Identifier);
Console.WriteLine(keyPair1.Private.ToString());
Console.WriteLine(keyPair1.Private.KeySize);
Console.WriteLine(keyPair1.Public.ToString());
Console.WriteLine(keyPair1.Public.KeySize);

var keyPair2 = new Secp256k1KeyPair();

Console.WriteLine("Keypair2 output");
Console.WriteLine(keyPair2.Algorithm.Identifier);
Console.WriteLine(keyPair2.Private.ToString());
Console.WriteLine(keyPair2.Private.KeySize);
Console.WriteLine(keyPair2.Public.ToString());
Console.WriteLine(keyPair2.Private.KeySize);

var message = Encoding.UTF8.GetBytes("BeHeroes");
var ed25519SignatureProvider = new Ed25519SignatureProvider((Ed25519Key)keyPair1.Private, (Ed25519Algorithm)keyPair1.Algorithm);
var signedBytes = ed25519SignatureProvider.Sign(message);

Console.WriteLine("Signed output");
Console.WriteLine((HexString)signedBytes);

ed25519SignatureProvider = new Ed25519SignatureProvider((Ed25519Key)keyPair1.Public, (Ed25519Algorithm)keyPair1.Algorithm);
Console.WriteLine(ed25519SignatureProvider.Verify(message, signedBytes));