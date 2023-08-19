using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace TwitterBot.Commands
{
    public class TweetCommand
    {
        private TwitterClient client;

        public TweetCommand(TwitterClient twitterClient) {
            this.client = twitterClient;
        }

        public async Task<Tweetinvi.Models.ITweet> Send(string message)
        {
            var tweetForSend = await client.Tweets.PublishTweetAsync(message);
            var tweetPublished = await client.Tweets.GetTweetAsync(tweetForSend.Id);

            return tweetPublished;
        }

        public async Task<Tweetinvi.Models.V2.TweetV2Response> Get(int  id)
        {
            var tweetSearch = await client.TweetsV2.GetTweetAsync(id);

            return tweetSearch;
        }
    }
}
