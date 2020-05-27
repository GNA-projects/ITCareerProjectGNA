using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.ChatBuissness
{
	public static class ChatServices
	{
		public static List<Users> GetUsers()
		{
			List<Users> users = new List<Users>();
			using (GNAEntities context = new GNAEntities())
			{
				users = context.Users.ToList();
			}
			return users;
		}

		public static void SendMessage(string message, int reciever_id)
		{
			using (GNAEntities context = new GNAEntities())
			{
				CurrentUser.user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
				ChatMessages chatMessage = new ChatMessages()
				{
					Time = DateTime.Now.ToString(),
					read = 0,
					Message = message,
					reciever_id = reciever_id,
					sender_id = CurrentUser.user.id,
				};
				CurrentUser.user.last_operation_id = 15;
				context.ChatMessages.Add(chatMessage);
				context.SaveChanges();
			}
		}

		public static int ReturnUnreadMessageId()
		{
			using (GNAEntities context = new GNAEntities())
			{
				int id;
				ChatMessages message = context.ChatMessages.FirstOrDefault(x => x.read == 0 && x.reciever_id == CurrentUser.user.id);
				if (message != null)
				{
					id = message.id;
				}
				else { id = -1; }

				return id;

			}

		}

		public static string GetUsers(int sender_id)
		{
			using (GNAEntities context = new GNAEntities())
			{
				return context.Users.FirstOrDefault(x => x.id == sender_id).username;
			}
		}

		public static ChatMessages ReturnMessage(int messageId)
		{
			using (GNAEntities context = new GNAEntities())
			{
				return context.ChatMessages.FirstOrDefault(x => x.id == messageId);
			}
		}
		public static List<ChatMessages> ReturnReadMessages(int chatFriendId)
		{
			using (GNAEntities context = new GNAEntities())
			{
				List<ChatMessages> allChatMessages = context.ChatMessages.Where(x => (x.sender_id == chatFriendId && x.reciever_id == CurrentUser.user.id) || (x.sender_id == CurrentUser.user.id && x.reciever_id == chatFriendId)).ToList();
				return allChatMessages.Where(x => x.read == 1).ToList();
			}
		}

		public static void SetFlagRead(int messageId)
		{
			using (GNAEntities context = new GNAEntities())
			{
				context.ChatMessages.FirstOrDefault(x => x.id == messageId).read = 1;
				context.SaveChanges();
			}
		}
	}
}
