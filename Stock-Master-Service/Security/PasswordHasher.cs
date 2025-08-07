﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_Service.Security
{
    public class PasswordHasher
    {
        private static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        private static readonly int saltSize = 16;
        private static readonly int hashSize = 20;
        private static readonly int iterations = 10000;

        public static string HashPassword(string password)
        {
            byte[] salt = new byte[saltSize];
            rng.GetBytes(salt);

            var key = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = key.GetBytes(hashSize);

            var hashBytes = new byte[saltSize + hashSize];
            Array.Copy(salt, 0, hashBytes, 0, saltSize);
            Array.Copy(hash, 0, hashBytes, saltSize, hashSize);

            var base64Hash = Convert.ToBase64String(hashBytes);

            return base64Hash;
        }

        public static bool VerifyPassword(string password, string base64HashedPassword)
        {
            var hashBytes = Convert.FromBase64String(base64HashedPassword);
            var salt = new byte[saltSize];
            Array.Copy(hashBytes, 0, salt, 0, saltSize);

            var key = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = key.GetBytes(hashSize);

            for (int i = 0; i < hashSize; i++)
            {
                if (hashBytes[i + saltSize] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}