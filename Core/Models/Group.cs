// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2014 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Models 
{
	public class Group : Principal 
	{

		public User Owner { get; set; }

		public Account Account { get; set; }

		public bool? IsShared { get; set; }

		public IEnumerable<Contact> Contacts { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as Group;
			if(typedSource != null)
			{
				Owner = typedSource.Owner;
				Account = typedSource.Account;
				IsShared = typedSource.IsShared;
				Contacts = typedSource.Contacts;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Owner", out token) && token.Type != JTokenType.Null)
				{
					Owner = (User)serializer.Deserialize(token.CreateReader(), typeof(User));
				}
				if(source.TryGetProperty("Account", out token) && token.Type != JTokenType.Null)
				{
					Account = (Account)serializer.Deserialize(token.CreateReader(), typeof(Account));
				}
				if(source.TryGetProperty("IsShared", out token) && token.Type != JTokenType.Null)
				{
					IsShared = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("Contacts", out token) && token.Type != JTokenType.Null)
				{
					Contacts = (IEnumerable<Contact>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<Contact>));
				}
			}
		}
	}
}