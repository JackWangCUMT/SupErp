﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34014
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SupErp.IHM.UserServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServices.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Login", ReplyAction="http://tempuri.org/IUserService/LoginResponse")]
        SupErp.Entities.User Login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Login", ReplyAction="http://tempuri.org/IUserService/LoginResponse")]
        System.Threading.Tasks.Task<SupErp.Entities.User> LoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserById", ReplyAction="http://tempuri.org/IUserService/GetUserByIdResponse")]
        SupErp.Entities.User GetUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserById", ReplyAction="http://tempuri.org/IUserService/GetUserByIdResponse")]
        System.Threading.Tasks.Task<SupErp.Entities.User> GetUserByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUsers", ReplyAction="http://tempuri.org/IUserService/GetUsersResponse")]
        System.Collections.Generic.List<SupErp.Entities.User> GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUsers", ReplyAction="http://tempuri.org/IUserService/GetUsersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<SupErp.Entities.User>> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetRoles", ReplyAction="http://tempuri.org/IUserService/GetRolesResponse")]
        System.Collections.Generic.List<SupErp.Entities.Role> GetRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetRoles", ReplyAction="http://tempuri.org/IUserService/GetRolesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<SupErp.Entities.Role>> GetRolesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetRoleByUserId", ReplyAction="http://tempuri.org/IUserService/GetRoleByUserIdResponse")]
        SupErp.Entities.Role GetRoleByUserId(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetRoleByUserId", ReplyAction="http://tempuri.org/IUserService/GetRoleByUserIdResponse")]
        System.Threading.Tasks.Task<SupErp.Entities.Role> GetRoleByUserIdAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/CreateUser", ReplyAction="http://tempuri.org/IUserService/CreateUserResponse")]
        SupErp.Entities.User CreateUser(SupErp.Entities.User userToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/CreateUser", ReplyAction="http://tempuri.org/IUserService/CreateUserResponse")]
        System.Threading.Tasks.Task<SupErp.Entities.User> CreateUserAsync(SupErp.Entities.User userToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/CreateRole", ReplyAction="http://tempuri.org/IUserService/CreateRoleResponse")]
        SupErp.Entities.Role CreateRole(SupErp.Entities.Role roleToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/CreateRole", ReplyAction="http://tempuri.org/IUserService/CreateRoleResponse")]
        System.Threading.Tasks.Task<SupErp.Entities.Role> CreateRoleAsync(SupErp.Entities.Role roleToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/EditUser", ReplyAction="http://tempuri.org/IUserService/EditUserResponse")]
        SupErp.Entities.User EditUser(SupErp.Entities.User userToEdit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/EditUser", ReplyAction="http://tempuri.org/IUserService/EditUserResponse")]
        System.Threading.Tasks.Task<SupErp.Entities.User> EditUserAsync(SupErp.Entities.User userToEdit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/EditRole", ReplyAction="http://tempuri.org/IUserService/EditRoleResponse")]
        SupErp.Entities.Role EditRole(SupErp.Entities.Role roleToEdit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/EditRole", ReplyAction="http://tempuri.org/IUserService/EditRoleResponse")]
        System.Threading.Tasks.Task<SupErp.Entities.Role> EditRoleAsync(SupErp.Entities.Role roleToEdit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteUser", ReplyAction="http://tempuri.org/IUserService/DeleteUserResponse")]
        bool DeleteUser(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteUser", ReplyAction="http://tempuri.org/IUserService/DeleteUserResponse")]
        System.Threading.Tasks.Task<bool> DeleteUserAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteRole", ReplyAction="http://tempuri.org/IUserService/DeleteRoleResponse")]
        bool DeleteRole(int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteRole", ReplyAction="http://tempuri.org/IUserService/DeleteRoleResponse")]
        System.Threading.Tasks.Task<bool> DeleteRoleAsync(int roleId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : SupErp.IHM.UserServices.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<SupErp.IHM.UserServices.IUserService>, SupErp.IHM.UserServices.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SupErp.Entities.User Login(string email, string password) {
            return base.Channel.Login(email, password);
        }
        
        public System.Threading.Tasks.Task<SupErp.Entities.User> LoginAsync(string email, string password) {
            return base.Channel.LoginAsync(email, password);
        }
        
        public SupErp.Entities.User GetUserById(int id) {
            return base.Channel.GetUserById(id);
        }
        
        public System.Threading.Tasks.Task<SupErp.Entities.User> GetUserByIdAsync(int id) {
            return base.Channel.GetUserByIdAsync(id);
        }
        
        public System.Collections.Generic.List<SupErp.Entities.User> GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<SupErp.Entities.User>> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public System.Collections.Generic.List<SupErp.Entities.Role> GetRoles() {
            return base.Channel.GetRoles();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<SupErp.Entities.Role>> GetRolesAsync() {
            return base.Channel.GetRolesAsync();
        }
        
        public SupErp.Entities.Role GetRoleByUserId(int userId) {
            return base.Channel.GetRoleByUserId(userId);
        }
        
        public System.Threading.Tasks.Task<SupErp.Entities.Role> GetRoleByUserIdAsync(int userId) {
            return base.Channel.GetRoleByUserIdAsync(userId);
        }
        
        public SupErp.Entities.User CreateUser(SupErp.Entities.User userToAdd) {
            return base.Channel.CreateUser(userToAdd);
        }
        
        public System.Threading.Tasks.Task<SupErp.Entities.User> CreateUserAsync(SupErp.Entities.User userToAdd) {
            return base.Channel.CreateUserAsync(userToAdd);
        }
        
        public SupErp.Entities.Role CreateRole(SupErp.Entities.Role roleToAdd) {
            return base.Channel.CreateRole(roleToAdd);
        }
        
        public System.Threading.Tasks.Task<SupErp.Entities.Role> CreateRoleAsync(SupErp.Entities.Role roleToAdd) {
            return base.Channel.CreateRoleAsync(roleToAdd);
        }
        
        public SupErp.Entities.User EditUser(SupErp.Entities.User userToEdit) {
            return base.Channel.EditUser(userToEdit);
        }
        
        public System.Threading.Tasks.Task<SupErp.Entities.User> EditUserAsync(SupErp.Entities.User userToEdit) {
            return base.Channel.EditUserAsync(userToEdit);
        }
        
        public SupErp.Entities.Role EditRole(SupErp.Entities.Role roleToEdit) {
            return base.Channel.EditRole(roleToEdit);
        }
        
        public System.Threading.Tasks.Task<SupErp.Entities.Role> EditRoleAsync(SupErp.Entities.Role roleToEdit) {
            return base.Channel.EditRoleAsync(roleToEdit);
        }
        
        public bool DeleteUser(int userId) {
            return base.Channel.DeleteUser(userId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteUserAsync(int userId) {
            return base.Channel.DeleteUserAsync(userId);
        }
        
        public bool DeleteRole(int roleId) {
            return base.Channel.DeleteRole(roleId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteRoleAsync(int roleId) {
            return base.Channel.DeleteRoleAsync(roleId);
        }
    }
}
