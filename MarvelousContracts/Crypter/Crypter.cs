namespace Marvelous.Contracts.Crypter
{
    using System.Security.Cryptography;

    namespace MarvelousConfigs.BLL.Crypter
    {
        public class Crypter
        {
            private Aes _handler { get; }

            public Crypter(string key, string iv)
            {
                _handler = Aes.Create();
                _handler.Key = Convert.FromBase64String(key);
                _handler.IV = Convert.FromBase64String(iv);
            }

            public string Encrypt(string source)
            {
                using (var mem = new MemoryStream())
                using (var stream = new CryptoStream(mem, _handler.CreateEncryptor(_handler.Key, _handler.IV),
                    CryptoStreamMode.Write))
                {
                    using (var writer = new StreamWriter(stream))
                    {
                        writer.Write(source);
                    }
                    return Convert.ToBase64String(mem.ToArray());
                }
            }

            public string Decrypt(string source)
            {
                var data = Convert.FromBase64String(source);
                using (var mem = new MemoryStream(data))
                using (var crypto = new CryptoStream(mem, _handler.CreateDecryptor(_handler.Key, _handler.IV),
                    CryptoStreamMode.Read))
                using (var reader = new StreamReader(crypto))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}