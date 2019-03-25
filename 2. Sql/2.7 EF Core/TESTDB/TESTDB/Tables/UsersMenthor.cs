﻿using System;
using System.Collections.Generic;
using TESTDB.Tables;

namespace TESTDB
{
    public partial class UsersMenthor
    {
        public UsersMenthor()
        {
            Themes = new HashSet<Themes>();
        }

        public long Id { get; set; }
        public long UserId { get; set; }

        public virtual Users User { get; set; }
        public virtual UsersIntern Interns { get; set; }
        public virtual ICollection<Themes> Themes { get; set; }
        public ICollection<MenthorProject> MenthorProjects { get; set; }
    }
}
