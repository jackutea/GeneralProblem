using System;
using System.Collections.Generic;

// DAO: Data Access Object
namespace GP.L1 {

    internal struct RoleEntity {
        public int id;
    }

    // Please implement following methods
    // Allow to add fields
    internal class ReleDAO {

        void Add(RoleEntity role) {
            throw new NotImplementedException();
        }

        public void Remove(RoleEntity role) {
            throw new NotImplementedException();
        }

        public bool TryGet(int id, out RoleEntity role) {
            throw new NotImplementedException();
        }

        public void Foreach(Action<RoleEntity> action) {
            throw new NotImplementedException();
        }

    }

}