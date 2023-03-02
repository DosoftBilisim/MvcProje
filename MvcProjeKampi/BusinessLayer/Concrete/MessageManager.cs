using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {

      
        IMessageDal _message;

        public MessageManager(IMessageDal mes)
        {
            _message = mes;
        }
        public Message GetByID(int id)
        {
            return _message.Get(x => x.MessageID == id);
        }

        public List<Message> GetListInbox(string p)
        {
            return _message.List(x=>x.ReceiverMail == p);
        }
        public List<Message> GetListSendbox(string p)
        {
            return _message.List(x => x.SenderMail == p);
        }

        public List<Message> GetList(string p)
        {
            throw new NotImplementedException();
        }

        public void MessageAdd(Message message)
        {
            _message.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            _message.Delete(message);
        }

        public void MessageUpdate(Message message)
        {
            _message.Update(message);
        }
    }
}
