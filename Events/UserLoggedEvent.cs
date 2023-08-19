using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace TwitterBot.Events
{
    public class UserLoggedEvent
    {
        private TwitterClient client;

        public UserLoggedEvent(TwitterClient twitterClient) { 
            this.client = twitterClient;
        }

        public async Task<Tweetinvi.Models.IAuthenticatedUser> GetUser()
        {
            var user = await client.Users.GetAuthenticatedUserAsync();
            return user;
        }
    }
}
