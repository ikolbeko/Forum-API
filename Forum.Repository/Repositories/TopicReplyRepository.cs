using Forum.Models.Entities;
using Forum.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Forum.Repository.Repositories
{
    public class TopicReplyRepository : Repository<TopicReply>, ITopicReplyRepository
    {
        private readonly DataContext _dbContext;
        public TopicReplyRepository(DataContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override IEnumerable<TopicReply> List(Expression<Func<TopicReply, bool>> predicate)
        {
            return _dbContext.TopicReplys.Include(r => r.ReplyUser).Where(predicate);
        }
    }
}
