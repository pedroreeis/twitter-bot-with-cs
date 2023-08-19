using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Core.Extensions;
using TwitterBot.Commands;
using TwitterBot.Events;

namespace TwitterBot
{
    class Twitter
    {

        public static void Main(String[] args)
        {
            /// Cria as variaveis onde se encontra os dados de autenticação
            string TWITTER_OAUTH2_CLIENT_ID = "";
            string TWITTER_OAUTH2_CLIENT_SECRET = "";
            string TWITTER_OAUTH2_ACCESS_TOKEN = "";
            string TWITTER_OAUTH2_REFRESH_TOKEN = "";

            // Construtor do client
            var clientTwitter = new TwitterClient(TWITTER_OAUTH2_CLIENT_ID, TWITTER_OAUTH2_CLIENT_SECRET, TWITTER_OAUTH2_ACCESS_TOKEN, TWITTER_OAUTH2_REFRESH_TOKEN);

            var tweetCommand = new TweetCommand(clientTwitter);

            /*
            tweetCommand.Send("Hello World!"); -> Retorna o Tweet enviado

            tweetCommand.Get(30); -> Retorna o conteudo do Tweet pesquisado
            */
        }
    }
}
