using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using PortaCapena.OdooJsonRpcClient.Attributes;

namespace ConsoleApp3
{
    [OdooTableName("res.users")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ResUsersOdooModel : IOdooModel
    {

        /// <summary>
        /// partner_id - many2one - res.partner <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Partner-related data of the user <br />
        /// </summary>
        [JsonProperty("partner_id")]
        public long? PartnerId { get; set; }

        /// <summary>
        /// login - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Used to log into the system <br />
        /// </summary>
        [JsonProperty("login")]
        public string? Login { get; set; }

        /// <summary>
        /// password - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Keep empty if you don't want the user to be able to connect on the system. <br />
        /// </summary>
        [JsonProperty("password")]
        public string? Password { get; set; }

        /// <summary>
        /// new_password - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Specify a value only when creating a user or if you're changing the user's password, otherwise leave empty. After a change of password, the user has to login again. <br />
        /// </summary>
        [JsonProperty("new_password")]
        public string? NewPassword { get; set; }

        /// <summary>
        /// signature - html  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// active - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// active_partner - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("active_partner")]
        public bool? ActivePartner { get; set; }

        /// <summary>
        /// action_id - many2one - ir.actions.actions <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: If specified, this action will be opened at log on for this user, in addition to the standard menu. <br />
        /// </summary>
        [JsonProperty("action_id")]
        public long? ActionId { get; set; }

        /// <summary>
        /// groups_id - many2many - res.groups <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("groups_id")]
        public long[]? GroupsId { get; set; }

        /// <summary>
        /// log_ids - one2many - res.users.log (create_uid) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("log_ids")]
        public long[]? LogIds { get; set; }

        /// <summary>
        /// login_date - datetime  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("login_date")]
        public DateTime? LoginDate { get; set; }

        /// <summary>
        /// share - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: External user with limited access, created only for the purpose of sharing data. <br />
        /// </summary>
        [JsonProperty("share")]
        public bool? Share { get; set; }

        /// <summary>
        /// companies_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("companies_count")]
        public int? CompaniesCount { get; set; }

        /// <summary>
        /// tz_offset - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("tz_offset")]
        public string? TzOffset { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The default company for this user. <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long CompanyId { get; set; }

        /// <summary>
        /// company_ids - many2many - res.company <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("company_ids")]
        public long[]? CompanyIds { get; set; }

        /// <summary>
        /// name - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// email - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// accesses_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of access rights that apply to the current user <br />
        /// </summary>
        [JsonProperty("accesses_count")]
        public int? AccessesCount { get; set; }

        /// <summary>
        /// rules_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of record rules that apply to the current user <br />
        /// </summary>
        [JsonProperty("rules_count")]
        public int? RulesCount { get; set; }

        /// <summary>
        /// groups_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of groups that apply to the current user <br />
        /// </summary>
        [JsonProperty("groups_count")]
        public int? GroupsCount { get; set; }

        /// <summary>
        /// id - integer  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// __last_update - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("__last_update")]
        public DateTime? LastUpdate { get; set; }

        /// <summary>
        /// display_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// create_uid - many2one - res.users <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("create_uid")]
        public long? CreateUid { get; set; }

        /// <summary>
        /// create_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("create_date")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// write_uid - many2one - res.users <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("write_uid")]
        public long? WriteUid { get; set; }

        /// <summary>
        /// write_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("write_date")]
        public DateTime? WriteDate { get; set; }

        /// <summary>
        /// user_group_warning - text  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("user_group_warning")]
        public string? UserGroupWarning { get; set; }

        /// <summary>
        /// api_key_ids - one2many - res.users.apikeys (user_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("api_key_ids")]
        public long[]? ApiKeyIds { get; set; }

        /// <summary>
        /// totp_enabled - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("totp_enabled")]
        public bool? TotpEnabled { get; set; }

        /// <summary>
        /// totp_trusted_device_ids - one2many - auth_totp.device (user_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("totp_trusted_device_ids")]
        public long[]? TotpTrustedDeviceIds { get; set; }

        /// <summary>
        /// im_status - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("im_status")]
        public string? ImStatus { get; set; }

        /// <summary>
        /// resource_ids - one2many - resource.resource (user_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("resource_ids")]
        public long[]? ResourceIds { get; set; }

        /// <summary>
        /// resource_calendar_id - many2one - resource.calendar <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("resource_calendar_id")]
        public long? ResourceCalendarId { get; set; }

        /// <summary>
        /// notification_type - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Policy on how to handle Chatter notifications:; - Handle by Emails: notifications are sent to your email address; - Handle in Odoo: notifications appear in your Odoo Inbox <br />
        /// </summary>
        [JsonProperty("notification_type")]
        public NotificationResUsersOdooEnum NotificationType { get; set; }

        /// <summary>
        /// res_users_settings_ids - one2many - res.users.settings (user_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("res_users_settings_ids")]
        public long[]? ResUsersSettingsIds { get; set; }

        /// <summary>
        /// res_users_settings_id - many2one - res.users.settings <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("res_users_settings_id")]
        public long? ResUsersSettingsId { get; set; }

        /// <summary>
        /// state - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("state")]
        public StatusResUsersOdooEnum? State { get; set; }

        /// <summary>
        /// odoobot_state - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("odoobot_state")]
        public OdoobotStatusResUsersOdooEnum? OdoobotState { get; set; }

        /// <summary>
        /// odoobot_failed - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("odoobot_failed")]
        public bool? OdoobotFailed { get; set; }

        /// <summary>
        /// sidebar_type - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sidebar_type")]
        public SidebarTypeResUsersOdooEnum SidebarType { get; set; }

        /// <summary>
        /// crm_team_ids - many2many - crm.team <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("crm_team_ids")]
        public long[]? CrmTeamIds { get; set; }

        /// <summary>
        /// crm_team_member_ids - one2many - crm.team.member (user_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("crm_team_member_ids")]
        public long[]? CrmTeamMemberIds { get; set; }

        /// <summary>
        /// sale_team_id - many2one - crm.team <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: Main user sales team. Used notably for pipeline, or to set sales team in invoicing or subscription. <br />
        /// </summary>
        [JsonProperty("sale_team_id")]
        public long? SaleTeamId { get; set; }

        /// <summary>
        /// target_sales_won - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("target_sales_won")]
        public int? TargetSalesWon { get; set; }

        /// <summary>
        /// target_sales_done - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("target_sales_done")]
        public int? TargetSalesDone { get; set; }

        /// <summary>
        /// website_id - many2one - website <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Restrict publishing to this website. <br />
        /// </summary>
        [JsonProperty("website_id")]
        public long? WebsiteId { get; set; }

        /// <summary>
        /// target_sales_invoiced - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("target_sales_invoiced")]
        public int? TargetSalesInvoiced { get; set; }

        /// <summary>
        /// property_warehouse_id - many2one - stock.warehouse <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("property_warehouse_id")]
        public long? PropertyWarehouseId { get; set; }

        /// <summary>
        /// website_published - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("website_published")]
        public bool? WebsitePublished { get; set; }

        /// <summary>
        /// is_published - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("is_published")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// can_publish - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("can_publish")]
        public bool? CanPublish { get; set; }

        /// <summary>
        /// website_url - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: The full URL to access the document through the website. <br />
        /// </summary>
        [JsonProperty("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// message_is_follower - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_is_follower")]
        public bool? MessageIsFollower { get; set; }

        /// <summary>
        /// message_follower_ids - one2many - mail.followers <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_follower_ids")]
        public long[]? MessageFollowerIds { get; set; }

        /// <summary>
        /// message_partner_ids - many2many - res.partner <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_partner_ids")]
        public long[]? MessagePartnerIds { get; set; }

        /// <summary>
        /// message_ids - one2many - mail.message <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_ids")]
        public long[]? MessageIds { get; set; }

        /// <summary>
        /// has_message - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("has_message")]
        public bool? HasMessage { get; set; }

        /// <summary>
        /// message_needaction - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked, new messages require your attention. <br />
        /// </summary>
        [JsonProperty("message_needaction")]
        public bool? MessageNeedaction { get; set; }

        /// <summary>
        /// message_needaction_counter - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of messages requiring action <br />
        /// </summary>
        [JsonProperty("message_needaction_counter")]
        public int? MessageNeedactionCounter { get; set; }

        /// <summary>
        /// message_has_error - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked, some messages have a delivery error. <br />
        /// </summary>
        [JsonProperty("message_has_error")]
        public bool? MessageHasError { get; set; }

        /// <summary>
        /// message_has_error_counter - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of messages with delivery error <br />
        /// </summary>
        [JsonProperty("message_has_error_counter")]
        public int? MessageHasErrorCounter { get; set; }

        /// <summary>
        /// message_attachment_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_attachment_count")]
        public int? MessageAttachmentCount { get; set; }

        /// <summary>
        /// message_main_attachment_id - many2one - ir.attachment <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("message_main_attachment_id")]
        public long? MessageMainAttachmentId { get; set; }

        /// <summary>
        /// website_message_ids - one2many - mail.message <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Website communication history <br />
        /// </summary>
        [JsonProperty("website_message_ids")]
        public long[]? WebsiteMessageIds { get; set; }

        /// <summary>
        /// message_has_sms_error - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked, some messages have a delivery error. <br />
        /// </summary>
        [JsonProperty("message_has_sms_error")]
        public bool? MessageHasSmsError { get; set; }

        /// <summary>
        /// email_normalized - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: True <br />
        /// Help: This field is used to search on email address as the primary email field can contain more than strictly an email address. <br />
        /// </summary>
        [JsonProperty("email_normalized")]
        public string? EmailNormalized { get; set; }

        /// <summary>
        /// is_blacklisted - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If the email address is on the blacklist, the contact won't receive mass mailing anymore, from any list <br />
        /// </summary>
        [JsonProperty("is_blacklisted")]
        public bool? IsBlacklisted { get; set; }

        /// <summary>
        /// message_bounce - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Counter of the number of bounced emails for this contact <br />
        /// </summary>
        [JsonProperty("message_bounce")]
        public int? MessageBounce { get; set; }

        /// <summary>
        /// activity_ids - one2many - mail.activity <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_ids")]
        public long[]? ActivityIds { get; set; }

        /// <summary>
        /// activity_state - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Status based on activities; Overdue: Due date is already passed; Today: Activity date is today; Planned: Future activities. <br />
        /// </summary>
        [JsonProperty("activity_state")]
        public ActivityStateResUsersOdooEnum? ActivityState { get; set; }

        /// <summary>
        /// activity_user_id - many2one - res.users <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_user_id")]
        public long? ActivityUserId { get; set; }

        /// <summary>
        /// activity_type_id - many2one - mail.activity.type <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_type_id")]
        public long? ActivityTypeId { get; set; }

        /// <summary>
        /// activity_type_icon - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Font awesome icon e.g. fa-tasks <br />
        /// </summary>
        [JsonProperty("activity_type_icon")]
        public string? ActivityTypeIcon { get; set; }

        /// <summary>
        /// activity_date_deadline - date  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_date_deadline")]
        public DateTime? ActivityDateDeadline { get; set; }

        /// <summary>
        /// my_activity_date_deadline - date  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("my_activity_date_deadline")]
        public DateTime? MyActivityDateDeadline { get; set; }

        /// <summary>
        /// activity_summary - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_summary")]
        public string? ActivitySummary { get; set; }

        /// <summary>
        /// activity_exception_decoration - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Type of the exception activity on record. <br />
        /// </summary>
        [JsonProperty("activity_exception_decoration")]
        public ActivityExceptionDecorationResUsersOdooEnum? ActivityExceptionDecoration { get; set; }

        /// <summary>
        /// activity_exception_icon - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Icon to indicate an exception activity. <br />
        /// </summary>
        [JsonProperty("activity_exception_icon")]
        public string? ActivityExceptionIcon { get; set; }

        /// <summary>
        /// activity_calendar_event_id - many2one - calendar.event <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_calendar_event_id")]
        public long? ActivityCalendarEventId { get; set; }

        /// <summary>
        /// image_1920 - binary  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("image_1920")]
        public string? Image1920 { get; set; }

        /// <summary>
        /// image_1024 - binary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("image_1024")]
        public string? Image1024 { get; set; }

        /// <summary>
        /// image_512 - binary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("image_512")]
        public string? Image512 { get; set; }

        /// <summary>
        /// image_256 - binary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("image_256")]
        public string? Image256 { get; set; }

        /// <summary>
        /// image_128 - binary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("image_128")]
        public string? Image128 { get; set; }

        /// <summary>
        /// avatar_1920 - binary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("avatar_1920")]
        public string? Avatar1920 { get; set; }

        /// <summary>
        /// avatar_1024 - binary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("avatar_1024")]
        public string? Avatar1024 { get; set; }

        /// <summary>
        /// avatar_512 - binary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("avatar_512")]
        public string? Avatar512 { get; set; }

        /// <summary>
        /// avatar_256 - binary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("avatar_256")]
        public string? Avatar256 { get; set; }

        /// <summary>
        /// avatar_128 - binary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("avatar_128")]
        public string? Avatar128 { get; set; }

        /// <summary>
        /// date - date  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// title - many2one - res.partner.title <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("title")]
        public long? Title { get; set; }

        /// <summary>
        /// parent_id - many2one - res.partner <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("parent_id")]
        public long? ParentId { get; set; }

        /// <summary>
        /// parent_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("parent_name")]
        public string? ParentName { get; set; }

        /// <summary>
        /// child_ids - one2many - res.partner <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("child_ids")]
        public long[]? ChildIds { get; set; }

        /// <summary>
        /// ref - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// lang - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: All the emails and documents sent to this contact will be translated in this language. <br />
        /// </summary>
        [JsonProperty("lang")]
        public LanguageResUsersOdooEnum? Lang { get; set; }

        /// <summary>
        /// active_lang_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("active_lang_count")]
        public int? ActiveLangCount { get; set; }

        /// <summary>
        /// tz - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: When printing documents and exporting/importing data, time values are computed according to this timezone.; If the timezone is not set, UTC (Coordinated Universal Time) is used.; Anywhere else, time values are computed according to the time offset of your web client. <br />
        /// </summary>
        [JsonProperty("tz")]
        public TimezoneResUsersOdooEnum? Tz { get; set; }

        /// <summary>
        /// user_id - many2one - res.users <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: The internal user in charge of this contact. <br />
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// vat - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: The Tax Identification Number. Values here will be validated based on the country format. You can use '/' to indicate that the partner is not subject to tax. <br />
        /// </summary>
        [JsonProperty("vat")]
        public string? Vat { get; set; }

        /// <summary>
        /// same_vat_partner_id - many2one - res.partner <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("same_vat_partner_id")]
        public long? SameVatPartnerId { get; set; }

        /// <summary>
        /// same_company_registry_partner_id - many2one - res.partner <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("same_company_registry_partner_id")]
        public long? SameCompanyRegistryPartnerId { get; set; }

        /// <summary>
        /// company_registry - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: The registry number of the company. Use it if it is different from the Tax ID. It must be unique across all partners of a same country <br />
        /// </summary>
        [JsonProperty("company_registry")]
        public string? CompanyRegistry { get; set; }

        /// <summary>
        /// bank_ids - one2many - res.partner.bank <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("bank_ids")]
        public long[]? BankIds { get; set; }

        /// <summary>
        /// website - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("website")]
        public string? Website { get; set; }

        /// <summary>
        /// comment - html  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// category_id - many2many - res.partner.category <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("category_id")]
        public long[]? CategoryId { get; set; }

        /// <summary>
        /// employee - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Check this box if this contact is an Employee. <br />
        /// </summary>
        [JsonProperty("employee")]
        public bool? Employee { get; set; }

        /// <summary>
        /// function - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("function")]
        public string? Function { get; set; }

        /// <summary>
        /// type - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: - Contact: Use this to organize the contact details of employees of a given company (e.g. CEO, CFO, ...).; - Invoice Address : Preferred address for all invoices. Selected by default when you invoice an order that belongs to this company.; - Delivery Address : Preferred address for all deliveries. Selected by default when you deliver an order that belongs to this company.; - Private: Private addresses are only visible by authorized users and contain sensitive data (employee home addresses, ...).; - Other: Other address for the company (e.g. subsidiary, ...) <br />
        /// </summary>
        [JsonProperty("type")]
        public AddressTypeResUsersOdooEnum? Type { get; set; }

        /// <summary>
        /// street - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("street")]
        public string? Street { get; set; }

        /// <summary>
        /// street2 - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("street2")]
        public string? Street2 { get; set; }

        /// <summary>
        /// zip - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("zip")]
        public string? Zip { get; set; }

        /// <summary>
        /// city - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// state_id - many2one - res.country.state <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("state_id")]
        public long? StateId { get; set; }

        /// <summary>
        /// country_id - many2one - res.country <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("country_id")]
        public long? CountryId { get; set; }

        /// <summary>
        /// country_code - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: The ISO country code in two chars. ; You can use this field for quick search. <br />
        /// </summary>
        [JsonProperty("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// partner_latitude - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("partner_latitude")]
        public double? PartnerLatitude { get; set; }

        /// <summary>
        /// partner_longitude - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("partner_longitude")]
        public double? PartnerLongitude { get; set; }

        /// <summary>
        /// email_formatted - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Format email address "Name <email@domain>" <br />
        /// </summary>
        [JsonProperty("email_formatted")]
        public string? EmailFormatted { get; set; }

        /// <summary>
        /// phone - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// mobile - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("mobile")]
        public string? Mobile { get; set; }

        /// <summary>
        /// is_company - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Check if the contact is a company, otherwise it is a person <br />
        /// </summary>
        [JsonProperty("is_company")]
        public bool? IsCompany { get; set; }

        /// <summary>
        /// is_public - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// industry_id - many2one - res.partner.industry <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("industry_id")]
        public long? IndustryId { get; set; }

        /// <summary>
        /// company_type - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("company_type")]
        public CompanyTypeResUsersOdooEnum? CompanyType { get; set; }

        /// <summary>
        /// color - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("color")]
        public int? Color { get; set; }

        /// <summary>
        /// user_ids - one2many - res.users <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("user_ids")]
        public long[]? UserIds { get; set; }

        /// <summary>
        /// partner_share - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: True <br />
        /// Help: Either customer (not a user), either shared user. Indicated the current partner is a customer without access or with a limited access created for sharing data. <br />
        /// </summary>
        [JsonProperty("partner_share")]
        public bool? PartnerShare { get; set; }

        /// <summary>
        /// contact_address - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("contact_address")]
        public string? ContactAddress { get; set; }

        /// <summary>
        /// commercial_partner_id - many2one - res.partner <br />
        /// Required: False, Readonly: True, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("commercial_partner_id")]
        public long? CommercialPartnerId { get; set; }

        /// <summary>
        /// commercial_company_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("commercial_company_name")]
        public string? CommercialCompanyName { get; set; }

        /// <summary>
        /// company_name - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// barcode - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Use a barcode to identify this contact. <br />
        /// </summary>
        [JsonProperty("barcode")]
        public string? Barcode { get; set; }

        /// <summary>
        /// self - many2one - res.partner <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("self")]
        public long? Self { get; set; }

        /// <summary>
        /// date_localization - date  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("date_localization")]
        public DateTime? DateLocalization { get; set; }

        /// <summary>
        /// channel_ids - many2many - mail.channel <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("channel_ids")]
        public long[]? ChannelIds { get; set; }

        /// <summary>
        /// signup_token - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("signup_token")]
        public string? SignupToken { get; set; }

        /// <summary>
        /// signup_type - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("signup_type")]
        public string? SignupType { get; set; }

        /// <summary>
        /// signup_expiration - datetime  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("signup_expiration")]
        public DateTime? SignupExpiration { get; set; }

        /// <summary>
        /// signup_valid - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("signup_valid")]
        public bool? SignupValid { get; set; }

        /// <summary>
        /// signup_url - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("signup_url")]
        public string? SignupUrl { get; set; }

        /// <summary>
        /// meeting_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("meeting_count")]
        public int? MeetingCount { get; set; }

        /// <summary>
        /// meeting_ids - many2many - calendar.event <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("meeting_ids")]
        public long[]? MeetingIds { get; set; }

        /// <summary>
        /// calendar_last_notif_ack - datetime  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("calendar_last_notif_ack")]
        public DateTime? CalendarLastNotifAck { get; set; }

        /// <summary>
        /// property_product_pricelist - many2one - product.pricelist <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This pricelist will be used, instead of the default one, for sales to the current partner <br />
        /// </summary>
        [JsonProperty("property_product_pricelist")]
        public long? PropertyProductPricelist { get; set; }

        /// <summary>
        /// team_id - many2one - crm.team <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: If set, this Sales Team will be used for sales and assignments related to this partner <br />
        /// </summary>
        [JsonProperty("team_id")]
        public long? TeamId { get; set; }

        /// <summary>
        /// partner_gid - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("partner_gid")]
        public int? PartnerGid { get; set; }

        /// <summary>
        /// additional_info - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("additional_info")]
        public string? AdditionalInfo { get; set; }

        /// <summary>
        /// phone_sanitized - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: True <br />
        /// Help: Field used to store sanitized phone number. Helps speeding up searches and comparisons. <br />
        /// </summary>
        [JsonProperty("phone_sanitized")]
        public string? PhoneSanitized { get; set; }

        /// <summary>
        /// phone_sanitized_blacklisted - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If the sanitized phone number is on the blacklist, the contact won't receive mass mailing sms anymore, from any list <br />
        /// </summary>
        [JsonProperty("phone_sanitized_blacklisted")]
        public bool? PhoneSanitizedBlacklisted { get; set; }

        /// <summary>
        /// phone_blacklisted - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Indicates if a blacklisted sanitized phone number is a phone number. Helps distinguish which number is blacklisted             when there is both a mobile and phone field in a model. <br />
        /// </summary>
        [JsonProperty("phone_blacklisted")]
        public bool? PhoneBlacklisted { get; set; }

        /// <summary>
        /// mobile_blacklisted - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Indicates if a blacklisted sanitized phone number is a mobile number. Helps distinguish which number is blacklisted             when there is both a mobile and phone field in a model. <br />
        /// </summary>
        [JsonProperty("mobile_blacklisted")]
        public bool? MobileBlacklisted { get; set; }

        /// <summary>
        /// phone_mobile_search - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("phone_mobile_search")]
        public string? PhoneMobileSearch { get; set; }

        /// <summary>
        /// payment_token_ids - one2many - payment.token <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("payment_token_ids")]
        public long[]? PaymentTokenIds { get; set; }

        /// <summary>
        /// payment_token_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("payment_token_count")]
        public int? PaymentTokenCount { get; set; }

        /// <summary>
        /// credit - monetary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Total amount this customer owes you. <br />
        /// </summary>
        [JsonProperty("credit")]
        public decimal? Credit { get; set; }

        /// <summary>
        /// credit_limit - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Credit limit specific to this partner. <br />
        /// </summary>
        [JsonProperty("credit_limit")]
        public double? CreditLimit { get; set; }

        /// <summary>
        /// use_partner_credit_limit - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("use_partner_credit_limit")]
        public bool? UsePartnerCreditLimit { get; set; }

        /// <summary>
        /// show_credit_limit - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("show_credit_limit")]
        public bool? ShowCreditLimit { get; set; }

        /// <summary>
        /// debit - monetary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Total amount you have to pay to this vendor. <br />
        /// </summary>
        [JsonProperty("debit")]
        public decimal? Debit { get; set; }

        /// <summary>
        /// debit_limit - monetary  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("debit_limit")]
        public decimal? DebitLimit { get; set; }

        /// <summary>
        /// total_invoiced - monetary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("total_invoiced")]
        public decimal? TotalInvoiced { get; set; }

        /// <summary>
        /// currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// journal_item_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("journal_item_count")]
        public int? JournalItemCount { get; set; }

        /// <summary>
        /// property_account_payable_id - many2one - account.account <br />
        /// Required: True, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This account will be used instead of the default one as the payable account for the current partner <br />
        /// </summary>
        [JsonProperty("property_account_payable_id")]
        public long PropertyAccountPayableId { get; set; }

        /// <summary>
        /// property_account_receivable_id - many2one - account.account <br />
        /// Required: True, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This account will be used instead of the default one as the receivable account for the current partner <br />
        /// </summary>
        [JsonProperty("property_account_receivable_id")]
        public long PropertyAccountReceivableId { get; set; }

        /// <summary>
        /// property_account_position_id - many2one - account.fiscal.position <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: The fiscal position determines the taxes/accounts used for this contact. <br />
        /// </summary>
        [JsonProperty("property_account_position_id")]
        public long? PropertyAccountPositionId { get; set; }

        /// <summary>
        /// property_payment_term_id - many2one - account.payment.term <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This payment term will be used instead of the default one for sales orders and customer invoices <br />
        /// </summary>
        [JsonProperty("property_payment_term_id")]
        public long? PropertyPaymentTermId { get; set; }

        /// <summary>
        /// property_supplier_payment_term_id - many2one - account.payment.term <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This payment term will be used instead of the default one for purchase orders and vendor bills <br />
        /// </summary>
        [JsonProperty("property_supplier_payment_term_id")]
        public long? PropertySupplierPaymentTermId { get; set; }

        /// <summary>
        /// ref_company_ids - one2many - res.company <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("ref_company_ids")]
        public long[]? RefCompanyIds { get; set; }

        /// <summary>
        /// has_unreconciled_entries - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: The partner has at least one unreconciled debit and credit since last time the invoices & payments matching was performed. <br />
        /// </summary>
        [JsonProperty("has_unreconciled_entries")]
        public bool? HasUnreconciledEntries { get; set; }

        /// <summary>
        /// last_time_entries_checked - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: True <br />
        /// Help: Last time the invoices & payments matching was performed for this partner. It is set either if there's not at least an unreconciled debit and an unreconciled credit or if you click the "Done" button. <br />
        /// </summary>
        [JsonProperty("last_time_entries_checked")]
        public DateTime? LastTimeEntriesChecked { get; set; }

        /// <summary>
        /// invoice_ids - one2many - account.move <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("invoice_ids")]
        public long[]? InvoiceIds { get; set; }

        /// <summary>
        /// contract_ids - one2many - account.analytic.account <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("contract_ids")]
        public long[]? ContractIds { get; set; }

        /// <summary>
        /// bank_account_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("bank_account_count")]
        public int? BankAccountCount { get; set; }

        /// <summary>
        /// trust - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("trust")]
        public DegreeOfTrustYouHaveInThisDebtorResUsersOdooEnum? Trust { get; set; }

        /// <summary>
        /// invoice_warn - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field. <br />
        /// </summary>
        [JsonProperty("invoice_warn")]
        public InvoiceResUsersOdooEnum? InvoiceWarn { get; set; }

        /// <summary>
        /// invoice_warn_msg - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("invoice_warn_msg")]
        public string? InvoiceWarnMsg { get; set; }

        /// <summary>
        /// supplier_rank - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("supplier_rank")]
        public int? SupplierRank { get; set; }

        /// <summary>
        /// customer_rank - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("customer_rank")]
        public int? CustomerRank { get; set; }

        /// <summary>
        /// duplicated_bank_account_partners_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("duplicated_bank_account_partners_count")]
        public int? DuplicatedBankAccountPartnersCount { get; set; }

        /// <summary>
        /// opportunity_ids - one2many - crm.lead <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("opportunity_ids")]
        public long[]? OpportunityIds { get; set; }

        /// <summary>
        /// opportunity_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("opportunity_count")]
        public int? OpportunityCount { get; set; }

        /// <summary>
        /// task_ids - one2many - project.task <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("task_ids")]
        public long[]? TaskIds { get; set; }

        /// <summary>
        /// task_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("task_count")]
        public int? TaskCount { get; set; }

        /// <summary>
        /// property_stock_customer - many2one - stock.location <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: The stock location used as destination when sending goods to this contact. <br />
        /// </summary>
        [JsonProperty("property_stock_customer")]
        public long? PropertyStockCustomer { get; set; }

        /// <summary>
        /// property_stock_supplier - many2one - stock.location <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: The stock location used as source when receiving goods from this contact. <br />
        /// </summary>
        [JsonProperty("property_stock_supplier")]
        public long? PropertyStockSupplier { get; set; }

        /// <summary>
        /// picking_warn - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field. <br />
        /// </summary>
        [JsonProperty("picking_warn")]
        public StockPickingResUsersOdooEnum? PickingWarn { get; set; }

        /// <summary>
        /// picking_warn_msg - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("picking_warn_msg")]
        public string? PickingWarnMsg { get; set; }

        /// <summary>
        /// visitor_ids - one2many - website.visitor <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("visitor_ids")]
        public long[]? VisitorIds { get; set; }

        /// <summary>
        /// vies_failed_message - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("vies_failed_message")]
        public string? ViesFailedMessage { get; set; }

        /// <summary>
        /// property_purchase_currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This currency will be used, instead of the default one, for purchases from the current partner <br />
        /// </summary>
        [JsonProperty("property_purchase_currency_id")]
        public long? PropertyPurchaseCurrencyId { get; set; }

        /// <summary>
        /// purchase_order_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("purchase_order_count")]
        public int? PurchaseOrderCount { get; set; }

        /// <summary>
        /// supplier_invoice_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("supplier_invoice_count")]
        public int? SupplierInvoiceCount { get; set; }

        /// <summary>
        /// purchase_warn - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field. <br />
        /// </summary>
        [JsonProperty("purchase_warn")]
        public PurchaseOrderResUsersOdooEnum? PurchaseWarn { get; set; }

        /// <summary>
        /// purchase_warn_msg - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("purchase_warn_msg")]
        public string? PurchaseWarnMsg { get; set; }

        /// <summary>
        /// receipt_reminder_email - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Automatically send a confirmation email to the vendor X days before the expected receipt date, asking him to confirm the exact date. <br />
        /// </summary>
        [JsonProperty("receipt_reminder_email")]
        public bool? ReceiptReminderEmail { get; set; }

        /// <summary>
        /// reminder_date_before_receipt - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Number of days to send reminder email before the promised receipt date <br />
        /// </summary>
        [JsonProperty("reminder_date_before_receipt")]
        public int? ReminderDateBeforeReceipt { get; set; }

        /// <summary>
        /// siret - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("siret")]
        public string? Siret { get; set; }

        /// <summary>
        /// pos_order_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: The number of point of sales orders related to this customer <br />
        /// </summary>
        [JsonProperty("pos_order_count")]
        public int? PosOrderCount { get; set; }

        /// <summary>
        /// pos_order_ids - one2many - pos.order <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("pos_order_ids")]
        public long[]? PosOrderIds { get; set; }

        /// <summary>
        /// purchase_line_ids - one2many - purchase.order.line <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("purchase_line_ids")]
        public long[]? PurchaseLineIds { get; set; }

        /// <summary>
        /// on_time_rate - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Over the past x days; the number of products received on time divided by the number of ordered products.x is either the System Parameter purchase_stock.on_time_delivery_days or the default 365 <br />
        /// </summary>
        [JsonProperty("on_time_rate")]
        public double? OnTimeRate { get; set; }

        /// <summary>
        /// sale_order_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sale_order_count")]
        public int? SaleOrderCount { get; set; }

        /// <summary>
        /// sale_order_ids - one2many - sale.order <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sale_order_ids")]
        public long[]? SaleOrderIds { get; set; }

        /// <summary>
        /// sale_warn - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field. <br />
        /// </summary>
        [JsonProperty("sale_warn")]
        public SalesWarningsResUsersOdooEnum? SaleWarn { get; set; }

        /// <summary>
        /// sale_warn_msg - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_warn_msg")]
        public string? SaleWarnMsg { get; set; }

        /// <summary>
        /// last_website_so_id - many2one - sale.order <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("last_website_so_id")]
        public long? LastWebsiteSoId { get; set; }

        /// <summary>
        /// property_delivery_carrier_id - many2one - delivery.carrier <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Default delivery method used in sales orders. <br />
        /// </summary>
        [JsonProperty("property_delivery_carrier_id")]
        public long? PropertyDeliveryCarrierId { get; set; }

        /// <summary>
        /// dropoff_site_ids - one2many - dropoff.site <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("dropoff_site_ids")]
        public long[]? DropoffSiteIds { get; set; }

        /// <summary>
        /// dropoff_site_id - many2one - dropoff.site <br />
        /// Required: False, Readonly: True, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("dropoff_site_id")]
        public long? DropoffSiteId { get; set; }

        /// <summary>
        /// dropoff_site_carrier_id - many2one - delivery.carrier <br />
        /// Required: False, Readonly: True, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("dropoff_site_carrier_id")]
        public long? DropoffSiteCarrierId { get; set; }

        /// <summary>
        /// is_dropoff_site - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("is_dropoff_site")]
        public bool? IsDropoffSite { get; set; }

        /// <summary>
        /// idcanal - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("idcanal")]
        public IDCANALLogisticsResUsersOdooEnum? Idcanal { get; set; }

        /// <summary>
        /// typecmd - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("typecmd")]
        public string? Typecmd { get; set; }

        /// <summary>
        /// idgroup - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: True <br />
        /// </summary>
        [JsonProperty("idgroup")]
        public string? Idgroup { get; set; }

        /// <summary>
        /// sel_groups_2_4 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sel_groups_2_4")]
        public AdministrationResUsersOdooEnum? SelGroups24 { get; set; }

        /// <summary>
        /// sel_groups_91 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sel_groups_91")]
        public OptionsLogisticsResUsersOdooEnum? SelGroups91 { get; set; }

        /// <summary>
        /// sel_groups_21_22_23 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Helps you handle your quotations, sale orders and invoicing.; ; User: Own Documents Only: the user will have access to his own data in the sales application.; User: All Documents: the user will have access to all records of everyone in the sales application.; Administrator: the user will have an access to the sales configuration as well as statistic reports. <br />
        /// </summary>
        [JsonProperty("sel_groups_21_22_23")]
        public SalesResUsersOdooEnum? SelGroups212223 { get; set; }

        /// <summary>
        /// sel_groups_64_65 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Helps you manage your projects and tasks by tracking them, generating plannings, etc...;  <br />
        /// </summary>
        [JsonProperty("sel_groups_64_65")]
        public ProjectResUsersOdooEnum? SelGroups6465 { get; set; }

        /// <summary>
        /// sel_groups_41_42 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Helps you manage your inventory and main stock operations: delivery orders, receptions, etc.;  <br />
        /// </summary>
        [JsonProperty("sel_groups_41_42")]
        public InventoryResUsersOdooEnum? SelGroups4142 { get; set; }

        /// <summary>
        /// sel_groups_77_78 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Helps you manage your manufacturing processes and generate reports on those processes.;  <br />
        /// </summary>
        [JsonProperty("sel_groups_77_78")]
        public ManufacturingResUsersOdooEnum? SelGroups7778 { get; set; }

        /// <summary>
        /// sel_groups_28_30 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Helps you handle your accounting needs, if you are not an accountant, we suggest you to install only the Invoicing.;  <br />
        /// </summary>
        [JsonProperty("sel_groups_28_30")]
        public InvoicingResUsersOdooEnum? SelGroups2830 { get; set; }

        /// <summary>
        /// sel_groups_58_59 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Helps you manage your purchase-related processes such as requests for quotations, supplier bills, etc...;  <br />
        /// </summary>
        [JsonProperty("sel_groups_58_59")]
        public PurchaseResUsersOdooEnum? SelGroups5859 { get; set; }

        /// <summary>
        /// sel_groups_1_10_11 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Helps you manage users.; ; Portal: Portal members have specific access rights (such as record rules and restricted menus).;                 They usually do not belong to the usual Odoo groups.; Public: Public users have specific access rights (such as record rules and restricted menus).;                 They usually do not belong to the usual Odoo groups. <br />
        /// </summary>
        [JsonProperty("sel_groups_1_10_11")]
        public UserTypesResUsersOdooEnum? SelGroups11011 { get; set; }

        /// <summary>
        /// sel_groups_87 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sel_groups_87")]
        public ConnectorResUsersOdooEnum? SelGroups87 { get; set; }

        /// <summary>
        /// sel_groups_86 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sel_groups_86")]
        public JobQueueResUsersOdooEnum? SelGroups86 { get; set; }

        /// <summary>
        /// sel_groups_62_63 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Helps you get the most out of your points of sale with fast sale encoding, simplified payment mode encoding, automatic picking lists generation and more.;  <br />
        /// </summary>
        [JsonProperty("sel_groups_62_63")]
        public PointOfSaleResUsersOdooEnum? SelGroups6263 { get; set; }

        /// <summary>
        /// sel_groups_72_73 - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sel_groups_72_73")]
        public WebsiteResUsersOdooEnum? SelGroups7273 { get; set; }

        /// <summary>
        /// in_group_31 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_31")]
        public bool? InGroup31 { get; set; }

        /// <summary>
        /// in_group_49 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_49")]
        public bool? InGroup49 { get; set; }

        /// <summary>
        /// in_group_60 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_60")]
        public bool? InGroup60 { get; set; }

        /// <summary>
        /// in_group_36 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_36")]
        public bool? InGroup36 { get; set; }

        /// <summary>
        /// in_group_12 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_12")]
        public bool? InGroup12 { get; set; }

        /// <summary>
        /// in_group_8 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_8")]
        public bool? InGroup8 { get; set; }

        /// <summary>
        /// in_group_17 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_17")]
        public bool? InGroup17 { get; set; }

        /// <summary>
        /// in_group_32 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_32")]
        public bool? InGroup32 { get; set; }

        /// <summary>
        /// in_group_15 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_15")]
        public bool? InGroup15 { get; set; }

        /// <summary>
        /// in_group_16 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_16")]
        public bool? InGroup16 { get; set; }

        /// <summary>
        /// in_group_76 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_76")]
        public bool? InGroup76 { get; set; }

        /// <summary>
        /// in_group_24 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_24")]
        public bool? InGroup24 { get; set; }

        /// <summary>
        /// in_group_20 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_20")]
        public bool? InGroup20 { get; set; }

        /// <summary>
        /// in_group_45 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_45")]
        public bool? InGroup45 { get; set; }

        /// <summary>
        /// in_group_54 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_54")]
        public bool? InGroup54 { get; set; }

        /// <summary>
        /// in_group_55 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_55")]
        public bool? InGroup55 { get; set; }

        /// <summary>
        /// in_group_35 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_35")]
        public bool? InGroup35 { get; set; }

        /// <summary>
        /// in_group_14 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_14")]
        public bool? InGroup14 { get; set; }

        /// <summary>
        /// in_group_48 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_48")]
        public bool? InGroup48 { get; set; }

        /// <summary>
        /// in_group_43 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_43")]
        public bool? InGroup43 { get; set; }

        /// <summary>
        /// in_group_39 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_39")]
        public bool? InGroup39 { get; set; }

        /// <summary>
        /// in_group_13 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_13")]
        public bool? InGroup13 { get; set; }

        /// <summary>
        /// in_group_40 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_40")]
        public bool? InGroup40 { get; set; }

        /// <summary>
        /// in_group_46 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_46")]
        public bool? InGroup46 { get; set; }

        /// <summary>
        /// in_group_18 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_18")]
        public bool? InGroup18 { get; set; }

        /// <summary>
        /// in_group_19 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_19")]
        public bool? InGroup19 { get; set; }

        /// <summary>
        /// in_group_47 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_47")]
        public bool? InGroup47 { get; set; }

        /// <summary>
        /// in_group_51 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_51")]
        public bool? InGroup51 { get; set; }

        /// <summary>
        /// in_group_79 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_79")]
        public bool? InGroup79 { get; set; }

        /// <summary>
        /// in_group_74 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_74")]
        public bool? InGroup74 { get; set; }

        /// <summary>
        /// in_group_44 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_44")]
        public bool? InGroup44 { get; set; }

        /// <summary>
        /// in_group_37 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_37")]
        public bool? InGroup37 { get; set; }

        /// <summary>
        /// in_group_80 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_80")]
        public bool? InGroup80 { get; set; }

        /// <summary>
        /// in_group_34 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_34")]
        public bool? InGroup34 { get; set; }

        /// <summary>
        /// in_group_38 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_38")]
        public bool? InGroup38 { get; set; }

        /// <summary>
        /// in_group_50 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_50")]
        public bool? InGroup50 { get; set; }

        /// <summary>
        /// in_group_33 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_33")]
        public bool? InGroup33 { get; set; }

        /// <summary>
        /// in_group_61 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_61")]
        public bool? InGroup61 { get; set; }

        /// <summary>
        /// in_group_56 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_56")]
        public bool? InGroup56 { get; set; }

        /// <summary>
        /// in_group_57 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_57")]
        public bool? InGroup57 { get; set; }

        /// <summary>
        /// in_group_25 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Show line subtotals without taxes (B2B) <br />
        /// </summary>
        [JsonProperty("in_group_25")]
        public bool? InGroup25 { get; set; }

        /// <summary>
        /// in_group_26 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Show line subtotals with taxes included (B2C) <br />
        /// </summary>
        [JsonProperty("in_group_26")]
        public bool? InGroup26 { get; set; }

        /// <summary>
        /// in_group_75 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_75")]
        public bool? InGroup75 { get; set; }

        /// <summary>
        /// in_group_81 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_81")]
        public bool? InGroup81 { get; set; }

        /// <summary>
        /// in_group_71 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_71")]
        public bool? InGroup71 { get; set; }

        /// <summary>
        /// in_group_83 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_83")]
        public bool? InGroup83 { get; set; }

        /// <summary>
        /// in_group_67 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_67")]
        public bool? InGroup67 { get; set; }

        /// <summary>
        /// in_group_52 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_52")]
        public bool? InGroup52 { get; set; }

        /// <summary>
        /// in_group_82 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_82")]
        public bool? InGroup82 { get; set; }

        /// <summary>
        /// in_group_69 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_69")]
        public bool? InGroup69 { get; set; }

        /// <summary>
        /// in_group_68 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_68")]
        public bool? InGroup68 { get; set; }

        /// <summary>
        /// in_group_66 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_66")]
        public bool? InGroup66 { get; set; }

        /// <summary>
        /// in_group_70 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_70")]
        public bool? InGroup70 { get; set; }

        /// <summary>
        /// in_group_53 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_53")]
        public bool? InGroup53 { get; set; }

        /// <summary>
        /// in_group_9 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_9")]
        public bool? InGroup9 { get; set; }

        /// <summary>
        /// in_group_5 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_5")]
        public bool? InGroup5 { get; set; }

        /// <summary>
        /// in_group_6 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_6")]
        public bool? InGroup6 { get; set; }

        /// <summary>
        /// in_group_7 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_7")]
        public bool? InGroup7 { get; set; }

        /// <summary>
        /// in_group_3 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_3")]
        public bool? InGroup3 { get; set; }

        /// <summary>
        /// in_group_92 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_92")]
        public bool? InGroup92 { get; set; }

        /// <summary>
        /// in_group_88 - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("in_group_88")]
        public bool? InGroup88 { get; set; }
    }


    /// <summary>
    /// Help: Policy on how to handle Chatter notifications: <br />
    /// - Handle by Emails: notifications are sent to your email address <br />
    /// - Handle in Odoo: notifications appear in your Odoo Inbox
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationResUsersOdooEnum
    {
        [EnumMember(Value = "email")]
        HandleByEmails = 1,

        [EnumMember(Value = "inbox")]
        HandleInOdoo = 2,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusResUsersOdooEnum
    {
        [EnumMember(Value = "new")]
        NeverConnected = 1,

        [EnumMember(Value = "active")]
        Confirmed = 2,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OdoobotStatusResUsersOdooEnum
    {
        [EnumMember(Value = "not_initialized")]
        NotInitialized = 1,

        [EnumMember(Value = "onboarding_emoji")]
        OnboardingEmoji = 2,

        [EnumMember(Value = "onboarding_attachement")]
        OnboardingAttachment = 3,

        [EnumMember(Value = "onboarding_command")]
        OnboardingCommand = 4,

        [EnumMember(Value = "onboarding_ping")]
        OnboardingPing = 5,

        [EnumMember(Value = "idle")]
        Idle = 6,

        [EnumMember(Value = "disabled")]
        Disabled = 7,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SidebarTypeResUsersOdooEnum
    {
        [EnumMember(Value = "invisible")]
        Invisible = 1,

        [EnumMember(Value = "small")]
        Small = 2,

        [EnumMember(Value = "large")]
        Large = 3,
    }


    /// <summary>
    /// Help: Status based on activities <br />
    /// Overdue: Due date is already passed <br />
    /// Today: Activity date is today <br />
    /// Planned: Future activities.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityStateResUsersOdooEnum
    {
        [EnumMember(Value = "overdue")]
        Overdue = 1,

        [EnumMember(Value = "today")]
        Today = 2,

        [EnumMember(Value = "planned")]
        Planned = 3,
    }


    /// <summary>
    /// Help: Type of the exception activity on record.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityExceptionDecorationResUsersOdooEnum
    {
        [EnumMember(Value = "warning")]
        Alert = 1,

        [EnumMember(Value = "danger")]
        Error = 2,
    }


    /// <summary>
    /// Help: All the emails and documents sent to this contact will be translated in this language.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LanguageResUsersOdooEnum
    {
        [EnumMember(Value = "fr_FR")]
        FrenchFranAis = 1,
    }


    /// <summary>
    /// Help: When printing documents and exporting/importing data, time values are computed according to this timezone. <br />
    /// If the timezone is not set, UTC (Coordinated Universal Time) is used. <br />
    /// Anywhere else, time values are computed according to the time offset of your web client.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TimezoneResUsersOdooEnum
    {
        [EnumMember(Value = "Africa/Abidjan")]
        AfricaAbidjan = 1,

        [EnumMember(Value = "Africa/Accra")]
        AfricaAccra = 2,

        [EnumMember(Value = "Africa/Addis_Ababa")]
        AfricaAddisAbaba = 3,

        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers = 4,

        [EnumMember(Value = "Africa/Asmara")]
        AfricaAsmara = 5,

        [EnumMember(Value = "Africa/Asmera")]
        AfricaAsmera = 6,

        [EnumMember(Value = "Africa/Bamako")]
        AfricaBamako = 7,

        [EnumMember(Value = "Africa/Bangui")]
        AfricaBangui = 8,

        [EnumMember(Value = "Africa/Banjul")]
        AfricaBanjul = 9,

        [EnumMember(Value = "Africa/Bissau")]
        AfricaBissau = 10,

        [EnumMember(Value = "Africa/Blantyre")]
        AfricaBlantyre = 11,

        [EnumMember(Value = "Africa/Brazzaville")]
        AfricaBrazzaville = 12,

        [EnumMember(Value = "Africa/Bujumbura")]
        AfricaBujumbura = 13,

        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo = 14,

        [EnumMember(Value = "Africa/Casablanca")]
        AfricaCasablanca = 15,

        [EnumMember(Value = "Africa/Ceuta")]
        AfricaCeuta = 16,

        [EnumMember(Value = "Africa/Conakry")]
        AfricaConakry = 17,

        [EnumMember(Value = "Africa/Dakar")]
        AfricaDakar = 18,

        [EnumMember(Value = "Africa/Dar_es_Salaam")]
        AfricaDarEsSalaam = 19,

        [EnumMember(Value = "Africa/Djibouti")]
        AfricaDjibouti = 20,

        [EnumMember(Value = "Africa/Douala")]
        AfricaDouala = 21,

        [EnumMember(Value = "Africa/El_Aaiun")]
        AfricaElAaiun = 22,

        [EnumMember(Value = "Africa/Freetown")]
        AfricaFreetown = 23,

        [EnumMember(Value = "Africa/Gaborone")]
        AfricaGaborone = 24,

        [EnumMember(Value = "Africa/Harare")]
        AfricaHarare = 25,

        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg = 26,

        [EnumMember(Value = "Africa/Juba")]
        AfricaJuba = 27,

        [EnumMember(Value = "Africa/Kampala")]
        AfricaKampala = 28,

        [EnumMember(Value = "Africa/Khartoum")]
        AfricaKhartoum = 29,

        [EnumMember(Value = "Africa/Kigali")]
        AfricaKigali = 30,

        [EnumMember(Value = "Africa/Kinshasa")]
        AfricaKinshasa = 31,

        [EnumMember(Value = "Africa/Lagos")]
        AfricaLagos = 32,

        [EnumMember(Value = "Africa/Libreville")]
        AfricaLibreville = 33,

        [EnumMember(Value = "Africa/Lome")]
        AfricaLome = 34,

        [EnumMember(Value = "Africa/Luanda")]
        AfricaLuanda = 35,

        [EnumMember(Value = "Africa/Lubumbashi")]
        AfricaLubumbashi = 36,

        [EnumMember(Value = "Africa/Lusaka")]
        AfricaLusaka = 37,

        [EnumMember(Value = "Africa/Malabo")]
        AfricaMalabo = 38,

        [EnumMember(Value = "Africa/Maputo")]
        AfricaMaputo = 39,

        [EnumMember(Value = "Africa/Maseru")]
        AfricaMaseru = 40,

        [EnumMember(Value = "Africa/Mbabane")]
        AfricaMbabane = 41,

        [EnumMember(Value = "Africa/Mogadishu")]
        AfricaMogadishu = 42,

        [EnumMember(Value = "Africa/Monrovia")]
        AfricaMonrovia = 43,

        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi = 44,

        [EnumMember(Value = "Africa/Ndjamena")]
        AfricaNdjamena = 45,

        [EnumMember(Value = "Africa/Niamey")]
        AfricaNiamey = 46,

        [EnumMember(Value = "Africa/Nouakchott")]
        AfricaNouakchott = 47,

        [EnumMember(Value = "Africa/Ouagadougou")]
        AfricaOuagadougou = 48,

        [EnumMember(Value = "Africa/Porto-Novo")]
        AfricaPortoNovo = 49,

        [EnumMember(Value = "Africa/Sao_Tome")]
        AfricaSaoTome = 50,

        [EnumMember(Value = "Africa/Timbuktu")]
        AfricaTimbuktu = 51,

        [EnumMember(Value = "Africa/Tripoli")]
        AfricaTripoli = 52,

        [EnumMember(Value = "Africa/Tunis")]
        AfricaTunis = 53,

        [EnumMember(Value = "Africa/Windhoek")]
        AfricaWindhoek = 54,

        [EnumMember(Value = "America/Adak")]
        AmericaAdak = 55,

        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage = 56,

        [EnumMember(Value = "America/Anguilla")]
        AmericaAnguilla = 57,

        [EnumMember(Value = "America/Antigua")]
        AmericaAntigua = 58,

        [EnumMember(Value = "America/Araguaina")]
        AmericaAraguaina = 59,

        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires = 60,

        [EnumMember(Value = "America/Argentina/Catamarca")]
        AmericaArgentinaCatamarca = 61,

        [EnumMember(Value = "America/Argentina/ComodRivadavia")]
        AmericaArgentinaComodrivadavia = 62,

        [EnumMember(Value = "America/Argentina/Cordoba")]
        AmericaArgentinaCordoba = 63,

        [EnumMember(Value = "America/Argentina/Jujuy")]
        AmericaArgentinaJujuy = 64,

        [EnumMember(Value = "America/Argentina/La_Rioja")]
        AmericaArgentinaLaRioja = 65,

        [EnumMember(Value = "America/Argentina/Mendoza")]
        AmericaArgentinaMendoza = 66,

        [EnumMember(Value = "America/Argentina/Rio_Gallegos")]
        AmericaArgentinaRioGallegos = 67,

        [EnumMember(Value = "America/Argentina/Salta")]
        AmericaArgentinaSalta = 68,

        [EnumMember(Value = "America/Argentina/San_Juan")]
        AmericaArgentinaSanJuan = 69,

        [EnumMember(Value = "America/Argentina/San_Luis")]
        AmericaArgentinaSanLuis = 70,

        [EnumMember(Value = "America/Argentina/Tucuman")]
        AmericaArgentinaTucuman = 71,

        [EnumMember(Value = "America/Argentina/Ushuaia")]
        AmericaArgentinaUshuaia = 72,

        [EnumMember(Value = "America/Aruba")]
        AmericaAruba = 73,

        [EnumMember(Value = "America/Asuncion")]
        AmericaAsuncion = 74,

        [EnumMember(Value = "America/Atikokan")]
        AmericaAtikokan = 75,

        [EnumMember(Value = "America/Atka")]
        AmericaAtka = 76,

        [EnumMember(Value = "America/Bahia")]
        AmericaBahia = 77,

        [EnumMember(Value = "America/Bahia_Banderas")]
        AmericaBahiaBanderas = 78,

        [EnumMember(Value = "America/Barbados")]
        AmericaBarbados = 79,

        [EnumMember(Value = "America/Belem")]
        AmericaBelem = 80,

        [EnumMember(Value = "America/Belize")]
        AmericaBelize = 81,

        [EnumMember(Value = "America/Blanc-Sablon")]
        AmericaBlancSablon = 82,

        [EnumMember(Value = "America/Boa_Vista")]
        AmericaBoaVista = 83,

        [EnumMember(Value = "America/Bogota")]
        AmericaBogota = 84,

        [EnumMember(Value = "America/Boise")]
        AmericaBoise = 85,

        [EnumMember(Value = "America/Buenos_Aires")]
        AmericaBuenosAires = 86,

        [EnumMember(Value = "America/Cambridge_Bay")]
        AmericaCambridgeBay = 87,

        [EnumMember(Value = "America/Campo_Grande")]
        AmericaCampoGrande = 88,

        [EnumMember(Value = "America/Cancun")]
        AmericaCancun = 89,

        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas = 90,

        [EnumMember(Value = "America/Catamarca")]
        AmericaCatamarca = 91,

        [EnumMember(Value = "America/Cayenne")]
        AmericaCayenne = 92,

        [EnumMember(Value = "America/Cayman")]
        AmericaCayman = 93,

        [EnumMember(Value = "America/Chicago")]
        AmericaChicago = 94,

        [EnumMember(Value = "America/Chihuahua")]
        AmericaChihuahua = 95,

        [EnumMember(Value = "America/Ciudad_Juarez")]
        AmericaCiudadJuarez = 96,

        [EnumMember(Value = "America/Coral_Harbour")]
        AmericaCoralHarbour = 97,

        [EnumMember(Value = "America/Cordoba")]
        AmericaCordoba = 98,

        [EnumMember(Value = "America/Costa_Rica")]
        AmericaCostaRica = 99,

        [EnumMember(Value = "America/Creston")]
        AmericaCreston = 100,

        [EnumMember(Value = "America/Cuiaba")]
        AmericaCuiaba = 101,

        [EnumMember(Value = "America/Curacao")]
        AmericaCuracao = 102,

        [EnumMember(Value = "America/Danmarkshavn")]
        AmericaDanmarkshavn = 103,

        [EnumMember(Value = "America/Dawson")]
        AmericaDawson = 104,

        [EnumMember(Value = "America/Dawson_Creek")]
        AmericaDawsonCreek = 105,

        [EnumMember(Value = "America/Denver")]
        AmericaDenver = 106,

        [EnumMember(Value = "America/Detroit")]
        AmericaDetroit = 107,

        [EnumMember(Value = "America/Dominica")]
        AmericaDominica = 108,

        [EnumMember(Value = "America/Edmonton")]
        AmericaEdmonton = 109,

        [EnumMember(Value = "America/Eirunepe")]
        AmericaEirunepe = 110,

        [EnumMember(Value = "America/El_Salvador")]
        AmericaElSalvador = 111,

        [EnumMember(Value = "America/Ensenada")]
        AmericaEnsenada = 112,

        [EnumMember(Value = "America/Fort_Nelson")]
        AmericaFortNelson = 113,

        [EnumMember(Value = "America/Fort_Wayne")]
        AmericaFortWayne = 114,

        [EnumMember(Value = "America/Fortaleza")]
        AmericaFortaleza = 115,

        [EnumMember(Value = "America/Glace_Bay")]
        AmericaGlaceBay = 116,

        [EnumMember(Value = "America/Godthab")]
        AmericaGodthab = 117,

        [EnumMember(Value = "America/Goose_Bay")]
        AmericaGooseBay = 118,

        [EnumMember(Value = "America/Grand_Turk")]
        AmericaGrandTurk = 119,

        [EnumMember(Value = "America/Grenada")]
        AmericaGrenada = 120,

        [EnumMember(Value = "America/Guadeloupe")]
        AmericaGuadeloupe = 121,

        [EnumMember(Value = "America/Guatemala")]
        AmericaGuatemala = 122,

        [EnumMember(Value = "America/Guayaquil")]
        AmericaGuayaquil = 123,

        [EnumMember(Value = "America/Guyana")]
        AmericaGuyana = 124,

        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax = 125,

        [EnumMember(Value = "America/Havana")]
        AmericaHavana = 126,

        [EnumMember(Value = "America/Hermosillo")]
        AmericaHermosillo = 127,

        [EnumMember(Value = "America/Indiana/Indianapolis")]
        AmericaIndianaIndianapolis = 128,

        [EnumMember(Value = "America/Indiana/Knox")]
        AmericaIndianaKnox = 129,

        [EnumMember(Value = "America/Indiana/Marengo")]
        AmericaIndianaMarengo = 130,

        [EnumMember(Value = "America/Indiana/Petersburg")]
        AmericaIndianaPetersburg = 131,

        [EnumMember(Value = "America/Indiana/Tell_City")]
        AmericaIndianaTellCity = 132,

        [EnumMember(Value = "America/Indiana/Vevay")]
        AmericaIndianaVevay = 133,

        [EnumMember(Value = "America/Indiana/Vincennes")]
        AmericaIndianaVincennes = 134,

        [EnumMember(Value = "America/Indiana/Winamac")]
        AmericaIndianaWinamac = 135,

        [EnumMember(Value = "America/Indianapolis")]
        AmericaIndianapolis = 136,

        [EnumMember(Value = "America/Inuvik")]
        AmericaInuvik = 137,

        [EnumMember(Value = "America/Iqaluit")]
        AmericaIqaluit = 138,

        [EnumMember(Value = "America/Jamaica")]
        AmericaJamaica = 139,

        [EnumMember(Value = "America/Jujuy")]
        AmericaJujuy = 140,

        [EnumMember(Value = "America/Juneau")]
        AmericaJuneau = 141,

        [EnumMember(Value = "America/Kentucky/Louisville")]
        AmericaKentuckyLouisville = 142,

        [EnumMember(Value = "America/Kentucky/Monticello")]
        AmericaKentuckyMonticello = 143,

        [EnumMember(Value = "America/Knox_IN")]
        AmericaKnoxIN = 144,

        [EnumMember(Value = "America/Kralendijk")]
        AmericaKralendijk = 145,

        [EnumMember(Value = "America/La_Paz")]
        AmericaLaPaz = 146,

        [EnumMember(Value = "America/Lima")]
        AmericaLima = 147,

        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles = 148,

        [EnumMember(Value = "America/Louisville")]
        AmericaLouisville = 149,

        [EnumMember(Value = "America/Lower_Princes")]
        AmericaLowerPrinces = 150,

        [EnumMember(Value = "America/Maceio")]
        AmericaMaceio = 151,

        [EnumMember(Value = "America/Managua")]
        AmericaManagua = 152,

        [EnumMember(Value = "America/Manaus")]
        AmericaManaus = 153,

        [EnumMember(Value = "America/Marigot")]
        AmericaMarigot = 154,

        [EnumMember(Value = "America/Martinique")]
        AmericaMartinique = 155,

        [EnumMember(Value = "America/Matamoros")]
        AmericaMatamoros = 156,

        [EnumMember(Value = "America/Mazatlan")]
        AmericaMazatlan = 157,

        [EnumMember(Value = "America/Mendoza")]
        AmericaMendoza = 158,

        [EnumMember(Value = "America/Menominee")]
        AmericaMenominee = 159,

        [EnumMember(Value = "America/Merida")]
        AmericaMerida = 160,

        [EnumMember(Value = "America/Metlakatla")]
        AmericaMetlakatla = 161,

        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity = 162,

        [EnumMember(Value = "America/Miquelon")]
        AmericaMiquelon = 163,

        [EnumMember(Value = "America/Moncton")]
        AmericaMoncton = 164,

        [EnumMember(Value = "America/Monterrey")]
        AmericaMonterrey = 165,

        [EnumMember(Value = "America/Montevideo")]
        AmericaMontevideo = 166,

        [EnumMember(Value = "America/Montreal")]
        AmericaMontreal = 167,

        [EnumMember(Value = "America/Montserrat")]
        AmericaMontserrat = 168,

        [EnumMember(Value = "America/Nassau")]
        AmericaNassau = 169,

        [EnumMember(Value = "America/New_York")]
        AmericaNewYork = 170,

        [EnumMember(Value = "America/Nipigon")]
        AmericaNipigon = 171,

        [EnumMember(Value = "America/Nome")]
        AmericaNome = 172,

        [EnumMember(Value = "America/Noronha")]
        AmericaNoronha = 173,

        [EnumMember(Value = "America/North_Dakota/Beulah")]
        AmericaNorthDakotaBeulah = 174,

        [EnumMember(Value = "America/North_Dakota/Center")]
        AmericaNorthDakotaCenter = 175,

        [EnumMember(Value = "America/North_Dakota/New_Salem")]
        AmericaNorthDakotaNewSalem = 176,

        [EnumMember(Value = "America/Nuuk")]
        AmericaNuuk = 177,

        [EnumMember(Value = "America/Ojinaga")]
        AmericaOjinaga = 178,

        [EnumMember(Value = "America/Panama")]
        AmericaPanama = 179,

        [EnumMember(Value = "America/Pangnirtung")]
        AmericaPangnirtung = 180,

        [EnumMember(Value = "America/Paramaribo")]
        AmericaParamaribo = 181,

        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix = 182,

        [EnumMember(Value = "America/Port-au-Prince")]
        AmericaPortAuPrince = 183,

        [EnumMember(Value = "America/Port_of_Spain")]
        AmericaPortOfSpain = 184,

        [EnumMember(Value = "America/Porto_Acre")]
        AmericaPortoAcre = 185,

        [EnumMember(Value = "America/Porto_Velho")]
        AmericaPortoVelho = 186,

        [EnumMember(Value = "America/Puerto_Rico")]
        AmericaPuertoRico = 187,

        [EnumMember(Value = "America/Punta_Arenas")]
        AmericaPuntaArenas = 188,

        [EnumMember(Value = "America/Rainy_River")]
        AmericaRainyRiver = 189,

        [EnumMember(Value = "America/Rankin_Inlet")]
        AmericaRankinInlet = 190,

        [EnumMember(Value = "America/Recife")]
        AmericaRecife = 191,

        [EnumMember(Value = "America/Regina")]
        AmericaRegina = 192,

        [EnumMember(Value = "America/Resolute")]
        AmericaResolute = 193,

        [EnumMember(Value = "America/Rio_Branco")]
        AmericaRioBranco = 194,

        [EnumMember(Value = "America/Rosario")]
        AmericaRosario = 195,

        [EnumMember(Value = "America/Santa_Isabel")]
        AmericaSantaIsabel = 196,

        [EnumMember(Value = "America/Santarem")]
        AmericaSantarem = 197,

        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago = 198,

        [EnumMember(Value = "America/Santo_Domingo")]
        AmericaSantoDomingo = 199,

        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo = 200,

        [EnumMember(Value = "America/Scoresbysund")]
        AmericaScoresbysund = 201,

        [EnumMember(Value = "America/Shiprock")]
        AmericaShiprock = 202,

        [EnumMember(Value = "America/Sitka")]
        AmericaSitka = 203,

        [EnumMember(Value = "America/St_Barthelemy")]
        AmericaStBarthelemy = 204,

        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns = 205,

        [EnumMember(Value = "America/St_Kitts")]
        AmericaStKitts = 206,

        [EnumMember(Value = "America/St_Lucia")]
        AmericaStLucia = 207,

        [EnumMember(Value = "America/St_Thomas")]
        AmericaStThomas = 208,

        [EnumMember(Value = "America/St_Vincent")]
        AmericaStVincent = 209,

        [EnumMember(Value = "America/Swift_Current")]
        AmericaSwiftCurrent = 210,

        [EnumMember(Value = "America/Tegucigalpa")]
        AmericaTegucigalpa = 211,

        [EnumMember(Value = "America/Thule")]
        AmericaThule = 212,

        [EnumMember(Value = "America/Thunder_Bay")]
        AmericaThunderBay = 213,

        [EnumMember(Value = "America/Tijuana")]
        AmericaTijuana = 214,

        [EnumMember(Value = "America/Toronto")]
        AmericaToronto = 215,

        [EnumMember(Value = "America/Tortola")]
        AmericaTortola = 216,

        [EnumMember(Value = "America/Vancouver")]
        AmericaVancouver = 217,

        [EnumMember(Value = "America/Virgin")]
        AmericaVirgin = 218,

        [EnumMember(Value = "America/Whitehorse")]
        AmericaWhitehorse = 219,

        [EnumMember(Value = "America/Winnipeg")]
        AmericaWinnipeg = 220,

        [EnumMember(Value = "America/Yakutat")]
        AmericaYakutat = 221,

        [EnumMember(Value = "America/Yellowknife")]
        AmericaYellowknife = 222,

        [EnumMember(Value = "Antarctica/Casey")]
        AntarcticaCasey = 223,

        [EnumMember(Value = "Antarctica/Davis")]
        AntarcticaDavis = 224,

        [EnumMember(Value = "Antarctica/DumontDUrville")]
        AntarcticaDumontdurville = 225,

        [EnumMember(Value = "Antarctica/Macquarie")]
        AntarcticaMacquarie = 226,

        [EnumMember(Value = "Antarctica/Mawson")]
        AntarcticaMawson = 227,

        [EnumMember(Value = "Antarctica/McMurdo")]
        AntarcticaMcmurdo = 228,

        [EnumMember(Value = "Antarctica/Palmer")]
        AntarcticaPalmer = 229,

        [EnumMember(Value = "Antarctica/Rothera")]
        AntarcticaRothera = 230,

        [EnumMember(Value = "Antarctica/South_Pole")]
        AntarcticaSouthPole = 231,

        [EnumMember(Value = "Antarctica/Syowa")]
        AntarcticaSyowa = 232,

        [EnumMember(Value = "Antarctica/Troll")]
        AntarcticaTroll = 233,

        [EnumMember(Value = "Antarctica/Vostok")]
        AntarcticaVostok = 234,

        [EnumMember(Value = "Arctic/Longyearbyen")]
        ArcticLongyearbyen = 235,

        [EnumMember(Value = "Asia/Aden")]
        AsiaAden = 236,

        [EnumMember(Value = "Asia/Almaty")]
        AsiaAlmaty = 237,

        [EnumMember(Value = "Asia/Amman")]
        AsiaAmman = 238,

        [EnumMember(Value = "Asia/Anadyr")]
        AsiaAnadyr = 239,

        [EnumMember(Value = "Asia/Aqtau")]
        AsiaAqtau = 240,

        [EnumMember(Value = "Asia/Aqtobe")]
        AsiaAqtobe = 241,

        [EnumMember(Value = "Asia/Ashgabat")]
        AsiaAshgabat = 242,

        [EnumMember(Value = "Asia/Ashkhabad")]
        AsiaAshkhabad = 243,

        [EnumMember(Value = "Asia/Atyrau")]
        AsiaAtyrau = 244,

        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad = 245,

        [EnumMember(Value = "Asia/Bahrain")]
        AsiaBahrain = 246,

        [EnumMember(Value = "Asia/Baku")]
        AsiaBaku = 247,

        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok = 248,

        [EnumMember(Value = "Asia/Barnaul")]
        AsiaBarnaul = 249,

        [EnumMember(Value = "Asia/Beirut")]
        AsiaBeirut = 250,

        [EnumMember(Value = "Asia/Bishkek")]
        AsiaBishkek = 251,

        [EnumMember(Value = "Asia/Brunei")]
        AsiaBrunei = 252,

        [EnumMember(Value = "Asia/Calcutta")]
        AsiaCalcutta = 253,

        [EnumMember(Value = "Asia/Chita")]
        AsiaChita = 254,

        [EnumMember(Value = "Asia/Choibalsan")]
        AsiaChoibalsan = 255,

        [EnumMember(Value = "Asia/Chongqing")]
        AsiaChongqing = 256,

        [EnumMember(Value = "Asia/Chungking")]
        AsiaChungking = 257,

        [EnumMember(Value = "Asia/Colombo")]
        AsiaColombo = 258,

        [EnumMember(Value = "Asia/Dacca")]
        AsiaDacca = 259,

        [EnumMember(Value = "Asia/Damascus")]
        AsiaDamascus = 260,

        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka = 261,

        [EnumMember(Value = "Asia/Dili")]
        AsiaDili = 262,

        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai = 263,

        [EnumMember(Value = "Asia/Dushanbe")]
        AsiaDushanbe = 264,

        [EnumMember(Value = "Asia/Famagusta")]
        AsiaFamagusta = 265,

        [EnumMember(Value = "Asia/Gaza")]
        AsiaGaza = 266,

        [EnumMember(Value = "Asia/Harbin")]
        AsiaHarbin = 267,

        [EnumMember(Value = "Asia/Hebron")]
        AsiaHebron = 268,

        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh = 269,

        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong = 270,

        [EnumMember(Value = "Asia/Hovd")]
        AsiaHovd = 271,

        [EnumMember(Value = "Asia/Irkutsk")]
        AsiaIrkutsk = 272,

        [EnumMember(Value = "Asia/Istanbul")]
        AsiaIstanbul = 273,

        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta = 274,

        [EnumMember(Value = "Asia/Jayapura")]
        AsiaJayapura = 275,

        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem = 276,

        [EnumMember(Value = "Asia/Kabul")]
        AsiaKabul = 277,

        [EnumMember(Value = "Asia/Kamchatka")]
        AsiaKamchatka = 278,

        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi = 279,

        [EnumMember(Value = "Asia/Kashgar")]
        AsiaKashgar = 280,

        [EnumMember(Value = "Asia/Kathmandu")]
        AsiaKathmandu = 281,

        [EnumMember(Value = "Asia/Katmandu")]
        AsiaKatmandu = 282,

        [EnumMember(Value = "Asia/Khandyga")]
        AsiaKhandyga = 283,

        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata = 284,

        [EnumMember(Value = "Asia/Krasnoyarsk")]
        AsiaKrasnoyarsk = 285,

        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur = 286,

        [EnumMember(Value = "Asia/Kuching")]
        AsiaKuching = 287,

        [EnumMember(Value = "Asia/Kuwait")]
        AsiaKuwait = 288,

        [EnumMember(Value = "Asia/Macao")]
        AsiaMacao = 289,

        [EnumMember(Value = "Asia/Macau")]
        AsiaMacau = 290,

        [EnumMember(Value = "Asia/Magadan")]
        AsiaMagadan = 291,

        [EnumMember(Value = "Asia/Makassar")]
        AsiaMakassar = 292,

        [EnumMember(Value = "Asia/Manila")]
        AsiaManila = 293,

        [EnumMember(Value = "Asia/Muscat")]
        AsiaMuscat = 294,

        [EnumMember(Value = "Asia/Nicosia")]
        AsiaNicosia = 295,

        [EnumMember(Value = "Asia/Novokuznetsk")]
        AsiaNovokuznetsk = 296,

        [EnumMember(Value = "Asia/Novosibirsk")]
        AsiaNovosibirsk = 297,

        [EnumMember(Value = "Asia/Omsk")]
        AsiaOmsk = 298,

        [EnumMember(Value = "Asia/Oral")]
        AsiaOral = 299,

        [EnumMember(Value = "Asia/Phnom_Penh")]
        AsiaPhnomPenh = 300,

        [EnumMember(Value = "Asia/Pontianak")]
        AsiaPontianak = 301,

        [EnumMember(Value = "Asia/Pyongyang")]
        AsiaPyongyang = 302,

        [EnumMember(Value = "Asia/Qatar")]
        AsiaQatar = 303,

        [EnumMember(Value = "Asia/Qostanay")]
        AsiaQostanay = 304,

        [EnumMember(Value = "Asia/Qyzylorda")]
        AsiaQyzylorda = 305,

        [EnumMember(Value = "Asia/Rangoon")]
        AsiaRangoon = 306,

        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh = 307,

        [EnumMember(Value = "Asia/Saigon")]
        AsiaSaigon = 308,

        [EnumMember(Value = "Asia/Sakhalin")]
        AsiaSakhalin = 309,

        [EnumMember(Value = "Asia/Samarkand")]
        AsiaSamarkand = 310,

        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul = 311,

        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai = 312,

        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore = 313,

        [EnumMember(Value = "Asia/Srednekolymsk")]
        AsiaSrednekolymsk = 314,

        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei = 315,

        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent = 316,

        [EnumMember(Value = "Asia/Tbilisi")]
        AsiaTbilisi = 317,

        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran = 318,

        [EnumMember(Value = "Asia/Tel_Aviv")]
        AsiaTelAviv = 319,

        [EnumMember(Value = "Asia/Thimbu")]
        AsiaThimbu = 320,

        [EnumMember(Value = "Asia/Thimphu")]
        AsiaThimphu = 321,

        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo = 322,

        [EnumMember(Value = "Asia/Tomsk")]
        AsiaTomsk = 323,

        [EnumMember(Value = "Asia/Ujung_Pandang")]
        AsiaUjungPandang = 324,

        [EnumMember(Value = "Asia/Ulaanbaatar")]
        AsiaUlaanbaatar = 325,

        [EnumMember(Value = "Asia/Ulan_Bator")]
        AsiaUlanBator = 326,

        [EnumMember(Value = "Asia/Urumqi")]
        AsiaUrumqi = 327,

        [EnumMember(Value = "Asia/Ust-Nera")]
        AsiaUstNera = 328,

        [EnumMember(Value = "Asia/Vientiane")]
        AsiaVientiane = 329,

        [EnumMember(Value = "Asia/Vladivostok")]
        AsiaVladivostok = 330,

        [EnumMember(Value = "Asia/Yakutsk")]
        AsiaYakutsk = 331,

        [EnumMember(Value = "Asia/Yangon")]
        AsiaYangon = 332,

        [EnumMember(Value = "Asia/Yekaterinburg")]
        AsiaYekaterinburg = 333,

        [EnumMember(Value = "Asia/Yerevan")]
        AsiaYerevan = 334,

        [EnumMember(Value = "Atlantic/Azores")]
        AtlanticAzores = 335,

        [EnumMember(Value = "Atlantic/Bermuda")]
        AtlanticBermuda = 336,

        [EnumMember(Value = "Atlantic/Canary")]
        AtlanticCanary = 337,

        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde = 338,

        [EnumMember(Value = "Atlantic/Faeroe")]
        AtlanticFaeroe = 339,

        [EnumMember(Value = "Atlantic/Faroe")]
        AtlanticFaroe = 340,

        [EnumMember(Value = "Atlantic/Jan_Mayen")]
        AtlanticJanMayen = 341,

        [EnumMember(Value = "Atlantic/Madeira")]
        AtlanticMadeira = 342,

        [EnumMember(Value = "Atlantic/Reykjavik")]
        AtlanticReykjavik = 343,

        [EnumMember(Value = "Atlantic/South_Georgia")]
        AtlanticSouthGeorgia = 344,

        [EnumMember(Value = "Atlantic/St_Helena")]
        AtlanticStHelena = 345,

        [EnumMember(Value = "Atlantic/Stanley")]
        AtlanticStanley = 346,

        [EnumMember(Value = "Australia/ACT")]
        AustraliaACT = 347,

        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide = 348,

        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane = 349,

        [EnumMember(Value = "Australia/Broken_Hill")]
        AustraliaBrokenHill = 350,

        [EnumMember(Value = "Australia/Canberra")]
        AustraliaCanberra = 351,

        [EnumMember(Value = "Australia/Currie")]
        AustraliaCurrie = 352,

        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin = 353,

        [EnumMember(Value = "Australia/Eucla")]
        AustraliaEucla = 354,

        [EnumMember(Value = "Australia/Hobart")]
        AustraliaHobart = 355,

        [EnumMember(Value = "Australia/LHI")]
        AustraliaLHI = 356,

        [EnumMember(Value = "Australia/Lindeman")]
        AustraliaLindeman = 357,

        [EnumMember(Value = "Australia/Lord_Howe")]
        AustraliaLordHowe = 358,

        [EnumMember(Value = "Australia/Melbourne")]
        AustraliaMelbourne = 359,

        [EnumMember(Value = "Australia/NSW")]
        AustraliaNSW = 360,

        [EnumMember(Value = "Australia/North")]
        AustraliaNorth = 361,

        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth = 362,

        [EnumMember(Value = "Australia/Queensland")]
        AustraliaQueensland = 363,

        [EnumMember(Value = "Australia/South")]
        AustraliaSouth = 364,

        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney = 365,

        [EnumMember(Value = "Australia/Tasmania")]
        AustraliaTasmania = 366,

        [EnumMember(Value = "Australia/Victoria")]
        AustraliaVictoria = 367,

        [EnumMember(Value = "Australia/West")]
        AustraliaWest = 368,

        [EnumMember(Value = "Australia/Yancowinna")]
        AustraliaYancowinna = 369,

        [EnumMember(Value = "Brazil/Acre")]
        BrazilAcre = 370,

        [EnumMember(Value = "Brazil/DeNoronha")]
        BrazilDenoronha = 371,

        [EnumMember(Value = "Brazil/East")]
        BrazilEast = 372,

        [EnumMember(Value = "Brazil/West")]
        BrazilWest = 373,

        [EnumMember(Value = "CET")]
        CET = 374,

        [EnumMember(Value = "CST6CDT")]
        CST6CDT = 375,

        [EnumMember(Value = "Canada/Atlantic")]
        CanadaAtlantic = 376,

        [EnumMember(Value = "Canada/Central")]
        CanadaCentral = 377,

        [EnumMember(Value = "Canada/Eastern")]
        CanadaEastern = 378,

        [EnumMember(Value = "Canada/Mountain")]
        CanadaMountain = 379,

        [EnumMember(Value = "Canada/Newfoundland")]
        CanadaNewfoundland = 380,

        [EnumMember(Value = "Canada/Pacific")]
        CanadaPacific = 381,

        [EnumMember(Value = "Canada/Saskatchewan")]
        CanadaSaskatchewan = 382,

        [EnumMember(Value = "Canada/Yukon")]
        CanadaYukon = 383,

        [EnumMember(Value = "Chile/Continental")]
        ChileContinental = 384,

        [EnumMember(Value = "Chile/EasterIsland")]
        ChileEasterisland = 385,

        [EnumMember(Value = "Cuba")]
        Cuba = 386,

        [EnumMember(Value = "EET")]
        EET = 387,

        [EnumMember(Value = "EST")]
        EST = 388,

        [EnumMember(Value = "EST5EDT")]
        EST5EDT = 389,

        [EnumMember(Value = "Egypt")]
        Egypt = 390,

        [EnumMember(Value = "Eire")]
        Eire = 391,

        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam = 392,

        [EnumMember(Value = "Europe/Andorra")]
        EuropeAndorra = 393,

        [EnumMember(Value = "Europe/Astrakhan")]
        EuropeAstrakhan = 394,

        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens = 395,

        [EnumMember(Value = "Europe/Belfast")]
        EuropeBelfast = 396,

        [EnumMember(Value = "Europe/Belgrade")]
        EuropeBelgrade = 397,

        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin = 398,

        [EnumMember(Value = "Europe/Bratislava")]
        EuropeBratislava = 399,

        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels = 400,

        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest = 401,

        [EnumMember(Value = "Europe/Budapest")]
        EuropeBudapest = 402,

        [EnumMember(Value = "Europe/Busingen")]
        EuropeBusingen = 403,

        [EnumMember(Value = "Europe/Chisinau")]
        EuropeChisinau = 404,

        [EnumMember(Value = "Europe/Copenhagen")]
        EuropeCopenhagen = 405,

        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin = 406,

        [EnumMember(Value = "Europe/Gibraltar")]
        EuropeGibraltar = 407,

        [EnumMember(Value = "Europe/Guernsey")]
        EuropeGuernsey = 408,

        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki = 409,

        [EnumMember(Value = "Europe/Isle_of_Man")]
        EuropeIsleOfMan = 410,

        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul = 411,

        [EnumMember(Value = "Europe/Jersey")]
        EuropeJersey = 412,

        [EnumMember(Value = "Europe/Kaliningrad")]
        EuropeKaliningrad = 413,

        [EnumMember(Value = "Europe/Kiev")]
        EuropeKiev = 414,

        [EnumMember(Value = "Europe/Kirov")]
        EuropeKirov = 415,

        [EnumMember(Value = "Europe/Kyiv")]
        EuropeKyiv = 416,

        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon = 417,

        [EnumMember(Value = "Europe/Ljubljana")]
        EuropeLjubljana = 418,

        [EnumMember(Value = "Europe/London")]
        EuropeLondon = 419,

        [EnumMember(Value = "Europe/Luxembourg")]
        EuropeLuxembourg = 420,

        [EnumMember(Value = "Europe/Madrid")]
        EuropeMadrid = 421,

        [EnumMember(Value = "Europe/Malta")]
        EuropeMalta = 422,

        [EnumMember(Value = "Europe/Mariehamn")]
        EuropeMariehamn = 423,

        [EnumMember(Value = "Europe/Minsk")]
        EuropeMinsk = 424,

        [EnumMember(Value = "Europe/Monaco")]
        EuropeMonaco = 425,

        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow = 426,

        [EnumMember(Value = "Europe/Nicosia")]
        EuropeNicosia = 427,

        [EnumMember(Value = "Europe/Oslo")]
        EuropeOslo = 428,

        [EnumMember(Value = "Europe/Paris")]
        EuropeParis = 429,

        [EnumMember(Value = "Europe/Podgorica")]
        EuropePodgorica = 430,

        [EnumMember(Value = "Europe/Prague")]
        EuropePrague = 431,

        [EnumMember(Value = "Europe/Riga")]
        EuropeRiga = 432,

        [EnumMember(Value = "Europe/Rome")]
        EuropeRome = 433,

        [EnumMember(Value = "Europe/Samara")]
        EuropeSamara = 434,

        [EnumMember(Value = "Europe/San_Marino")]
        EuropeSanMarino = 435,

        [EnumMember(Value = "Europe/Sarajevo")]
        EuropeSarajevo = 436,

        [EnumMember(Value = "Europe/Saratov")]
        EuropeSaratov = 437,

        [EnumMember(Value = "Europe/Simferopol")]
        EuropeSimferopol = 438,

        [EnumMember(Value = "Europe/Skopje")]
        EuropeSkopje = 439,

        [EnumMember(Value = "Europe/Sofia")]
        EuropeSofia = 440,

        [EnumMember(Value = "Europe/Stockholm")]
        EuropeStockholm = 441,

        [EnumMember(Value = "Europe/Tallinn")]
        EuropeTallinn = 442,

        [EnumMember(Value = "Europe/Tirane")]
        EuropeTirane = 443,

        [EnumMember(Value = "Europe/Tiraspol")]
        EuropeTiraspol = 444,

        [EnumMember(Value = "Europe/Ulyanovsk")]
        EuropeUlyanovsk = 445,

        [EnumMember(Value = "Europe/Uzhgorod")]
        EuropeUzhgorod = 446,

        [EnumMember(Value = "Europe/Vaduz")]
        EuropeVaduz = 447,

        [EnumMember(Value = "Europe/Vatican")]
        EuropeVatican = 448,

        [EnumMember(Value = "Europe/Vienna")]
        EuropeVienna = 449,

        [EnumMember(Value = "Europe/Vilnius")]
        EuropeVilnius = 450,

        [EnumMember(Value = "Europe/Volgograd")]
        EuropeVolgograd = 451,

        [EnumMember(Value = "Europe/Warsaw")]
        EuropeWarsaw = 452,

        [EnumMember(Value = "Europe/Zagreb")]
        EuropeZagreb = 453,

        [EnumMember(Value = "Europe/Zaporozhye")]
        EuropeZaporozhye = 454,

        [EnumMember(Value = "Europe/Zurich")]
        EuropeZurich = 455,

        [EnumMember(Value = "GB")]
        GB = 456,

        [EnumMember(Value = "GB-Eire")]
        GBEire = 457,

        [EnumMember(Value = "GMT")]
        GMT = 458,

        [EnumMember(Value = "GMT+0")]
        Gmtplus0 = 459,

        [EnumMember(Value = "GMT-0")]
        GMT0 = 460,

        [EnumMember(Value = "GMT0")]
        GMT1 = 461,

        [EnumMember(Value = "Greenwich")]
        Greenwich = 462,

        [EnumMember(Value = "HST")]
        HST = 463,

        [EnumMember(Value = "Hongkong")]
        Hongkong = 464,

        [EnumMember(Value = "Iceland")]
        Iceland = 465,

        [EnumMember(Value = "Indian/Antananarivo")]
        IndianAntananarivo = 466,

        [EnumMember(Value = "Indian/Chagos")]
        IndianChagos = 467,

        [EnumMember(Value = "Indian/Christmas")]
        IndianChristmas = 468,

        [EnumMember(Value = "Indian/Cocos")]
        IndianCocos = 469,

        [EnumMember(Value = "Indian/Comoro")]
        IndianComoro = 470,

        [EnumMember(Value = "Indian/Kerguelen")]
        IndianKerguelen = 471,

        [EnumMember(Value = "Indian/Mahe")]
        IndianMahe = 472,

        [EnumMember(Value = "Indian/Maldives")]
        IndianMaldives = 473,

        [EnumMember(Value = "Indian/Mauritius")]
        IndianMauritius = 474,

        [EnumMember(Value = "Indian/Mayotte")]
        IndianMayotte = 475,

        [EnumMember(Value = "Indian/Reunion")]
        IndianReunion = 476,

        [EnumMember(Value = "Iran")]
        Iran = 477,

        [EnumMember(Value = "Israel")]
        Israel = 478,

        [EnumMember(Value = "Jamaica")]
        Jamaica = 479,

        [EnumMember(Value = "Japan")]
        Japan = 480,

        [EnumMember(Value = "Kwajalein")]
        Kwajalein = 481,

        [EnumMember(Value = "Libya")]
        Libya = 482,

        [EnumMember(Value = "MET")]
        MET = 483,

        [EnumMember(Value = "MST")]
        MST = 484,

        [EnumMember(Value = "MST7MDT")]
        MST7MDT = 485,

        [EnumMember(Value = "Mexico/BajaNorte")]
        MexicoBajanorte = 486,

        [EnumMember(Value = "Mexico/BajaSur")]
        MexicoBajasur = 487,

        [EnumMember(Value = "Mexico/General")]
        MexicoGeneral = 488,

        [EnumMember(Value = "NZ")]
        NZ = 489,

        [EnumMember(Value = "NZ-CHAT")]
        NZCHAT = 490,

        [EnumMember(Value = "Navajo")]
        Navajo = 491,

        [EnumMember(Value = "PRC")]
        PRC = 492,

        [EnumMember(Value = "PST8PDT")]
        PST8PDT = 493,

        [EnumMember(Value = "Pacific/Apia")]
        PacificApia = 494,

        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland = 495,

        [EnumMember(Value = "Pacific/Bougainville")]
        PacificBougainville = 496,

        [EnumMember(Value = "Pacific/Chatham")]
        PacificChatham = 497,

        [EnumMember(Value = "Pacific/Chuuk")]
        PacificChuuk = 498,

        [EnumMember(Value = "Pacific/Easter")]
        PacificEaster = 499,

        [EnumMember(Value = "Pacific/Efate")]
        PacificEfate = 500,

        [EnumMember(Value = "Pacific/Enderbury")]
        PacificEnderbury = 501,

        [EnumMember(Value = "Pacific/Fakaofo")]
        PacificFakaofo = 502,

        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji = 503,

        [EnumMember(Value = "Pacific/Funafuti")]
        PacificFunafuti = 504,

        [EnumMember(Value = "Pacific/Galapagos")]
        PacificGalapagos = 505,

        [EnumMember(Value = "Pacific/Gambier")]
        PacificGambier = 506,

        [EnumMember(Value = "Pacific/Guadalcanal")]
        PacificGuadalcanal = 507,

        [EnumMember(Value = "Pacific/Guam")]
        PacificGuam = 508,

        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu = 509,

        [EnumMember(Value = "Pacific/Johnston")]
        PacificJohnston = 510,

        [EnumMember(Value = "Pacific/Kanton")]
        PacificKanton = 511,

        [EnumMember(Value = "Pacific/Kiritimati")]
        PacificKiritimati = 512,

        [EnumMember(Value = "Pacific/Kosrae")]
        PacificKosrae = 513,

        [EnumMember(Value = "Pacific/Kwajalein")]
        PacificKwajalein = 514,

        [EnumMember(Value = "Pacific/Majuro")]
        PacificMajuro = 515,

        [EnumMember(Value = "Pacific/Marquesas")]
        PacificMarquesas = 516,

        [EnumMember(Value = "Pacific/Midway")]
        PacificMidway = 517,

        [EnumMember(Value = "Pacific/Nauru")]
        PacificNauru = 518,

        [EnumMember(Value = "Pacific/Niue")]
        PacificNiue = 519,

        [EnumMember(Value = "Pacific/Norfolk")]
        PacificNorfolk = 520,

        [EnumMember(Value = "Pacific/Noumea")]
        PacificNoumea = 521,

        [EnumMember(Value = "Pacific/Pago_Pago")]
        PacificPagoPago = 522,

        [EnumMember(Value = "Pacific/Palau")]
        PacificPalau = 523,

        [EnumMember(Value = "Pacific/Pitcairn")]
        PacificPitcairn = 524,

        [EnumMember(Value = "Pacific/Pohnpei")]
        PacificPohnpei = 525,

        [EnumMember(Value = "Pacific/Ponape")]
        PacificPonape = 526,

        [EnumMember(Value = "Pacific/Port_Moresby")]
        PacificPortMoresby = 527,

        [EnumMember(Value = "Pacific/Rarotonga")]
        PacificRarotonga = 528,

        [EnumMember(Value = "Pacific/Saipan")]
        PacificSaipan = 529,

        [EnumMember(Value = "Pacific/Samoa")]
        PacificSamoa = 530,

        [EnumMember(Value = "Pacific/Tahiti")]
        PacificTahiti = 531,

        [EnumMember(Value = "Pacific/Tarawa")]
        PacificTarawa = 532,

        [EnumMember(Value = "Pacific/Tongatapu")]
        PacificTongatapu = 533,

        [EnumMember(Value = "Pacific/Truk")]
        PacificTruk = 534,

        [EnumMember(Value = "Pacific/Wake")]
        PacificWake = 535,

        [EnumMember(Value = "Pacific/Wallis")]
        PacificWallis = 536,

        [EnumMember(Value = "Pacific/Yap")]
        PacificYap = 537,

        [EnumMember(Value = "Poland")]
        Poland = 538,

        [EnumMember(Value = "Portugal")]
        Portugal = 539,

        [EnumMember(Value = "ROC")]
        ROC = 540,

        [EnumMember(Value = "ROK")]
        ROK = 541,

        [EnumMember(Value = "Singapore")]
        Singapore = 542,

        [EnumMember(Value = "Turkey")]
        Turkey = 543,

        [EnumMember(Value = "UCT")]
        UCT = 544,

        [EnumMember(Value = "US/Alaska")]
        USAlaska = 545,

        [EnumMember(Value = "US/Aleutian")]
        USAleutian = 546,

        [EnumMember(Value = "US/Arizona")]
        USArizona = 547,

        [EnumMember(Value = "US/Central")]
        USCentral = 548,

        [EnumMember(Value = "US/East-Indiana")]
        USEastIndiana = 549,

        [EnumMember(Value = "US/Eastern")]
        USEastern = 550,

        [EnumMember(Value = "US/Hawaii")]
        USHawaii = 551,

        [EnumMember(Value = "US/Indiana-Starke")]
        USIndianaStarke = 552,

        [EnumMember(Value = "US/Michigan")]
        USMichigan = 553,

        [EnumMember(Value = "US/Mountain")]
        USMountain = 554,

        [EnumMember(Value = "US/Pacific")]
        USPacific = 555,

        [EnumMember(Value = "US/Samoa")]
        USSamoa = 556,

        [EnumMember(Value = "UTC")]
        UTC = 557,

        [EnumMember(Value = "Universal")]
        Universal = 558,

        [EnumMember(Value = "W-SU")]
        WSU = 559,

        [EnumMember(Value = "WET")]
        WET = 560,

        [EnumMember(Value = "Zulu")]
        Zulu = 561,

        [EnumMember(Value = "Etc/GMT")]
        EtcGMT = 562,

        [EnumMember(Value = "Etc/GMT+0")]
        EtcGmtplus0 = 563,

        [EnumMember(Value = "Etc/GMT+1")]
        EtcGmtplus1 = 564,

        [EnumMember(Value = "Etc/GMT+10")]
        EtcGmtplus10 = 565,

        [EnumMember(Value = "Etc/GMT+11")]
        EtcGmtplus11 = 566,

        [EnumMember(Value = "Etc/GMT+12")]
        EtcGmtplus12 = 567,

        [EnumMember(Value = "Etc/GMT+2")]
        EtcGmtplus2 = 568,

        [EnumMember(Value = "Etc/GMT+3")]
        EtcGmtplus3 = 569,

        [EnumMember(Value = "Etc/GMT+4")]
        EtcGmtplus4 = 570,

        [EnumMember(Value = "Etc/GMT+5")]
        EtcGmtplus5 = 571,

        [EnumMember(Value = "Etc/GMT+6")]
        EtcGmtplus6 = 572,

        [EnumMember(Value = "Etc/GMT+7")]
        EtcGmtplus7 = 573,

        [EnumMember(Value = "Etc/GMT+8")]
        EtcGmtplus8 = 574,

        [EnumMember(Value = "Etc/GMT+9")]
        EtcGmtplus9 = 575,

        [EnumMember(Value = "Etc/GMT-0")]
        EtcGMT0 = 576,

        [EnumMember(Value = "Etc/GMT-1")]
        EtcGMT1 = 577,

        [EnumMember(Value = "Etc/GMT-10")]
        EtcGMT10 = 578,

        [EnumMember(Value = "Etc/GMT-11")]
        EtcGMT11 = 579,

        [EnumMember(Value = "Etc/GMT-12")]
        EtcGMT12 = 580,

        [EnumMember(Value = "Etc/GMT-13")]
        EtcGMT13 = 581,

        [EnumMember(Value = "Etc/GMT-14")]
        EtcGMT14 = 582,

        [EnumMember(Value = "Etc/GMT-2")]
        EtcGMT2 = 583,

        [EnumMember(Value = "Etc/GMT-3")]
        EtcGMT3 = 584,

        [EnumMember(Value = "Etc/GMT-4")]
        EtcGMT4 = 585,

        [EnumMember(Value = "Etc/GMT-5")]
        EtcGMT5 = 586,

        [EnumMember(Value = "Etc/GMT-6")]
        EtcGMT6 = 587,

        [EnumMember(Value = "Etc/GMT-7")]
        EtcGMT7 = 588,

        [EnumMember(Value = "Etc/GMT-8")]
        EtcGMT8 = 589,

        [EnumMember(Value = "Etc/GMT-9")]
        EtcGMT9 = 590,

        [EnumMember(Value = "Etc/GMT0")]
        EtcGMT15 = 591,

        [EnumMember(Value = "Etc/Greenwich")]
        EtcGreenwich = 592,

        [EnumMember(Value = "Etc/UCT")]
        EtcUCT = 593,

        [EnumMember(Value = "Etc/UTC")]
        EtcUTC = 594,

        [EnumMember(Value = "Etc/Universal")]
        EtcUniversal = 595,

        [EnumMember(Value = "Etc/Zulu")]
        EtcZulu = 596,
    }


    /// <summary>
    /// Help: - Contact: Use this to organize the contact details of employees of a given company (e.g. CEO, CFO, ...). <br />
    /// - Invoice Address : Preferred address for all invoices. Selected by default when you invoice an order that belongs to this company. <br />
    /// - Delivery Address : Preferred address for all deliveries. Selected by default when you deliver an order that belongs to this company. <br />
    /// - Private: Private addresses are only visible by authorized users and contain sensitive data (employee home addresses, ...). <br />
    /// - Other: Other address for the company (e.g. subsidiary, ...)
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressTypeResUsersOdooEnum
    {
        [EnumMember(Value = "contact")]
        Contact = 1,

        [EnumMember(Value = "invoice")]
        InvoiceAddress = 2,

        [EnumMember(Value = "delivery")]
        DeliveryAddress = 3,

        [EnumMember(Value = "private")]
        PrivateAddress = 4,

        [EnumMember(Value = "other")]
        OtherAddress = 5,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompanyTypeResUsersOdooEnum
    {
        [EnumMember(Value = "person")]
        Individual = 1,

        [EnumMember(Value = "company")]
        Company = 2,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DegreeOfTrustYouHaveInThisDebtorResUsersOdooEnum
    {
        [EnumMember(Value = "good")]
        GoodDebtor = 1,

        [EnumMember(Value = "normal")]
        NormalDebtor = 2,

        [EnumMember(Value = "bad")]
        BadDebtor = 3,
    }


    /// <summary>
    /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceResUsersOdooEnum
    {
        [EnumMember(Value = "no-message")]
        NoMessage = 1,

        [EnumMember(Value = "warning")]
        Warning = 2,

        [EnumMember(Value = "block")]
        BlockingMessage = 3,
    }


    /// <summary>
    /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StockPickingResUsersOdooEnum
    {
        [EnumMember(Value = "no-message")]
        NoMessage = 1,

        [EnumMember(Value = "warning")]
        Warning = 2,

        [EnumMember(Value = "block")]
        BlockingMessage = 3,
    }


    /// <summary>
    /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PurchaseOrderResUsersOdooEnum
    {
        [EnumMember(Value = "no-message")]
        NoMessage = 1,

        [EnumMember(Value = "warning")]
        Warning = 2,

        [EnumMember(Value = "block")]
        BlockingMessage = 3,
    }


    /// <summary>
    /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SalesWarningsResUsersOdooEnum
    {
        [EnumMember(Value = "no-message")]
        NoMessage = 1,

        [EnumMember(Value = "warning")]
        Warning = 2,

        [EnumMember(Value = "block")]
        BlockingMessage = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IDCANALLogisticsResUsersOdooEnum
    {
        [EnumMember(Value = "WEB")]
        WEB = 1,

        [EnumMember(Value = "PRO")]
        PRO = 2,

        [EnumMember(Value = "MARKETPLACE")]
        MARKETPLACE = 3,

        [EnumMember(Value = "DISTRIBUTEUR")]
        DISTRIBUTEUR = 4,

        [EnumMember(Value = "REASSORT")]
        REASSORT = 5,

        [EnumMember(Value = "SPECIAL")]
        SPECIAL = 6,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdministrationResUsersOdooEnum
    {
        [EnumMember(Value = "False")]
        None = 1,

        [EnumMember(Value = "2")]
        AccessRights = 2,

        [EnumMember(Value = "4")]
        Settings = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OptionsLogisticsResUsersOdooEnum
    {
        [EnumMember(Value = "False")]
        None = 1,

        [EnumMember(Value = "91")]
        CanChangeLogisticStates = 2,
    }


    /// <summary>
    /// Help: Helps you handle your quotations, sale orders and invoicing. <br />
    ///  <br />
    /// User: Own Documents Only: the user will have access to his own data in the sales application. <br />
    /// User: All Documents: the user will have access to all records of everyone in the sales application. <br />
    /// Administrator: the user will have an access to the sales configuration as well as statistic reports.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SalesResUsersOdooEnum
    {
        [EnumMember(Value = "False")]
        None = 1,

        [EnumMember(Value = "21")]
        UserOwnDocumentsOnly = 2,

        [EnumMember(Value = "22")]
        UserAllDocuments = 3,

        [EnumMember(Value = "23")]
        Administrator = 4,
    }


    /// <summary>
    /// Help: Helps you manage your projects and tasks by tracking them, generating plannings, etc... <br />
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProjectResUsersOdooEnum
    {
        [EnumMember(Value = "False")]
        None = 1,

        [EnumMember(Value = "64")]
        User = 2,

        [EnumMember(Value = "65")]
        Administrator = 3,
    }


    /// <summary>
    /// Help: Helps you manage your inventory and main stock operations: delivery orders, receptions, etc. <br />
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InventoryResUsersOdooEnum
    {
        [EnumMember(Value = "False")]
        None = 1,

        [EnumMember(Value = "41")]
        User = 2,

        [EnumMember(Value = "42")]
        Administrator = 3,
    }


    /// <summary>
    /// Help: Helps you manage your manufacturing processes and generate reports on those processes. <br />
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManufacturingResUsersOdooEnum
    {
        [EnumMember(Value = "False")]
        None = 1,

        [EnumMember(Value = "77")]
        User = 2,

        [EnumMember(Value = "78")]
        Administrator = 3,
    }


    /// <summary>
    /// Help: Helps you handle your accounting needs, if you are not an accountant, we suggest you to install only the Invoicing. <br />
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoicingResUsersOdooEnum
    {
        [EnumMember(Value = "False")]
        None = 1,

        [EnumMember(Value = "28")]
        Billing = 2,

        [EnumMember(Value = "30")]
        BillingAdministrator = 3,
    }


    /// <summary>
    /// Help: Helps you manage your purchase-related processes such as requests for quotations, supplier bills, etc... <br />
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PurchaseResUsersOdooEnum
    {
        [EnumMember(Value = "False")]
        None = 1,

        [EnumMember(Value = "58")]
        User = 2,

        [EnumMember(Value = "59")]
        Administrator = 3,
    }


    /// <summary>
    /// Help: Helps you manage users. <br />
    ///  <br />
    /// Portal: Portal members have specific access rights (such as record rules and restricted menus). <br />
    ///                 They usually do not belong to the usual Odoo groups. <br />
    /// Public: Public users have specific access rights (such as record rules and restricted menus). <br />
    ///                 They usually do not belong to the usual Odoo groups.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserTypesResUsersOdooEnum
    {
        [EnumMember(Value = "1")]
        InternalUser = 1,

        [EnumMember(Value = "10")]
        Portal = 2,

        [EnumMember(Value = "11")]
        Public = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConnectorResUsersOdooEnum
    {
        [EnumMember(Value = "False")]
        None = 1,

        [EnumMember(Value = "87")]
        ConnectorManager = 2,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobQueueResUsersOdooEnum
    {
        [EnumMember(Value = "False")]
        None = 1,

        [EnumMember(Value = "86")]
        JobQueueManager = 2,
    }


    /// <summary>
    /// Help: Helps you get the most out of your points of sale with fast sale encoding, simplified payment mode encoding, automatic picking lists generation and more. <br />
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PointOfSaleResUsersOdooEnum
    {
        [EnumMember(Value = "False")]
        None = 1,

        [EnumMember(Value = "62")]
        User = 2,

        [EnumMember(Value = "63")]
        Administrator = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebsiteResUsersOdooEnum
    {
        [EnumMember(Value = "False")]
        None = 1,

        [EnumMember(Value = "72")]
        RestrictedEditor = 2,

        [EnumMember(Value = "73")]
        EditorAndDesigner = 3,
    }
}
