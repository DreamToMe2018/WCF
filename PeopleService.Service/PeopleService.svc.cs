﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PeopleService.Service
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼、svc 和組態檔中的類別名稱 "PeopleService"。
    // 注意: 若要啟動 WCF 測試用戶端以便測試此服務，請在 [方案總管] 中選取 PeopleService.svc 或 PeopleService.svc.cs，然後開始偵錯。
    public class PeopleService : IPeopleService
    {
        public List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person{ Age = 45, FirstName = "John", LastName = "Smith" },
                new Person { Age = 42, FirstName = "Jane", LastName = "Smith" }
            };
        }
    }
}
