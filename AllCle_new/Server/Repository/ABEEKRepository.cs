﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Server.Models;
using Dapper;
using Server.IRepository;

namespace Server.Repository
{
    public class ABEEKRepository : IABEEKRepository
    {
        private IConfiguration _config;
        private SqlConnection db;
        public ABEEKRepository(IConfiguration config)                                             // db 설정하는 메소드
        {
            _config = config;

            // IConfiguration 개체를 통해서 
            // appsettings.json의 데이터베이스 연결 문자열을 읽어온다. 
            db = new SqlConnection(
                _config.GetSection("ConnectionStrings").GetSection(
                    "DefaultConnection").Value);
        }

        public List<ABEEK> GetABEEK()
        {
            string sql = "Select * From ABEEK18_1";
            return db.Query<ABEEK>(sql).ToList();
        }
    }
}
