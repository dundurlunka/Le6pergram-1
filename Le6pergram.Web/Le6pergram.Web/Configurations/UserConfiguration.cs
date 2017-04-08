﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Le6pergram.Web.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.HasMany(u => u.Followers).WithMany(f => f.Following).Map(uf =>
            {
                uf.MapLeftKey("UserId");
                uf.MapRightKey("FollowerId");
                uf.ToTable("UsersFollowers");
            });
            this.Ignore(u => u.RepeatPassword);
            this.Ignore(u => u.picturesCount);
        }
    }
}