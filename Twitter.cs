using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Core.Extensions;
using TwitterBot.Events;

namespace TwitterBot
{
    class Twitter
    {

        public static void Main(String[] args)
        {
            /// Cria as variaveis onde se encontra os dados de autenticação
            string TWITTER_OAUTH2_CLIENT_ID = "L2EO6RB2FA9pvIq6eSEDgxPlw";
            string TWITTER_OAUTH2_CLIENT_SECRET = "5XqMGqKOKvITbbUQkE3f0Xue9KATTg0tDcv4bG7DW12RhaobAv";
            string TWITTER_OAUTH2_ACCESS_TOKEN = "943604245911228417-1SrXLbcpsMm3ABmgdi1BDZKGNWcyu84";
            string TWITTER_OAUTH2_REFRESH_TOKEN = "QXvGfHIB5szZAiJMluXhMxp4yUqm7s8eBttk3KoUe90eA";

            // Construtor do client
            var clientTwitter = new TwitterClient(TWITTER_OAUTH2_CLIENT_ID, TWITTER_OAUTH2_CLIENT_SECRET, TWITTER_OAUTH2_ACCESS_TOKEN, TWITTER_OAUTH2_REFRESH_TOKEN);

            // Chama o evento criado para pegar o usuario autenticado
            Task<Tweetinvi.Models.IAuthenticatedUser> user = new UserLoggedEvent(clientTwitter).GetUser();

            // Printa no console o usuario.
            Console.WriteLine("Seu usuário é: " + user.Result.ScreenName);
        }
    }
}
