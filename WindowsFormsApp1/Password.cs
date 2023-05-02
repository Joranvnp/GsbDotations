using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    class Password
    {
        // Hash un mot de passe en prenant en paramètre un mot de passe (en clair à hasher), paramètres optionnels : salt (passer un sel), needsOnlyHash (retourne que le hash du passe)
        public static string HashPassword(string password, byte[] salt = null, bool needsOnlyHash = false)
        {
            if (salt == null || salt.Length != 16)
            {
                // Génère un sel d'une longueur de 128 bits en utilisant un nombre aléatoire
                salt = new byte[128 / 8];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(salt);
                }
            }

            // Le hashage se fait via l'algorithme SHA256, on hash le mot de passe avec le sel généré
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            if (needsOnlyHash) return hashed;

            // Le mot de passe est retourné sous le format : le hash + ":" + le sel généré
            return $"{hashed}:{Convert.ToBase64String(salt)}";
        }

        // Vérifie un mot de passe hashé en prenant en paramètres : le mot de passe hashé avec son sel, et le mot de passe à vérifier
        public static bool VerifyPassword(string hashedPasswordWithSalt, string passwordToCheck)
        {
            // Retrouve le sel et le hash
            var passwordAndHash = hashedPasswordWithSalt.Split(':');
            if (passwordAndHash == null || passwordAndHash.Length != 2)
                return false;
            var salt = Convert.FromBase64String(passwordAndHash[1]);
            if (salt == null)
                return false;

            // Hash le mot de passe à vérifier avec le sel récupérer
            var hashOfpasswordToCheck = HashPassword(passwordToCheck, salt, true);

            // Et on compare les deux hashs. S'ils sont égaux alors c'est que le mot de passe est vérifié !
            if (String.Compare(passwordAndHash[0], hashOfpasswordToCheck) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
