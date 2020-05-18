using RetroFun.Controls;
using RetroFun.Pages;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace RetroFun
{
    [DesignerCategory("Form")]
    [Module("RetroFun", "All-in-one scripting tool!")]
    [Author("marcocorriero")]



    public partial class MainFrm : ObservableExtensionForm
    {
        public override bool IsRemoteModule => true;



        
        public bool IsAlwaysOnTop
        {
            get => TopMost;
            set
            {
                TopMost = value;
                RaiseOnPropertyChanged();
            }
        }


        private List<ObservablePage> _subscribers = new List<ObservablePage>();

        public MainFrm()
        {
            // Must be set before initializing components.
            Program.Master = this;
            InitializeComponent();

            //Pages sharing events
            _subscribers = new List<ObservablePage>
            {
                ChatPg,
                DicePg,
                FurniPg,
                MakeSayPg,
                SpeechzPg,
                GiftEditorPg,
                StalkingPg,
                AutoHoloDicePg,
                AvatarEditorPg,
                MiscellaneousPg,
                BuyFurniBruteforcerPg,
                FakeMessagePg,
                RoomBackFunPg,
                furniSpawnPg,
                MoonLightFunPg,
                DiscoRoomFunPg,
                BottomPg,
                FurniTrollPg,
                UtilitiesPg,
                PetPg,
                UserEditorPg,
                PersonalPg,
                ModerationPg,
                FurnitureCheckerPg,
             };
                
            Bind(AlwaysOnTopChbx, "Checked", nameof(IsAlwaysOnTop));
        }

         // WHEN ADDING A PACKET, FIND IF THE HandleOutGoing and HandleIncoming In or Out headers are decommented
        // this way it should register and work with the virtual voids!
        // The virtual voids are set for all known packets registered in sulakore
        

        public override void HandleOutgoing(DataInterceptedEventArgs e)
        {
            int id = e.Packet.Header;
            foreach (var sub in _subscribers)
            {
                e.Packet.Position = 0;
                if (Out.AdvertisingSave == id)
                {
                    sub.Out_AdvertisingSave(e);
                }
                //else if (Out.AcceptFriendRequest == id)
                //{
                //    sub.Out_AcceptFriendRequest(e);
                //}
                //else if (Out.ActivateEffect == id)
                //{
                //    sub.Out_ActivateEffect(e);
                //}
                //else if (Out.AdventCalendarForceOpen == id)
                //{
                //    sub.Out_AdventCalendarForceOpen(e);
                //}
                //else if (Out.AdventCalendarOpenDay == id)
                //{
                //    sub.Out_AdventCalendarOpenDay(e);
                //}

                //else if (Out.AmbassadorAlertCommand == id)
                //{
                //    sub.Out_AmbassadorAlertCommand(e);
                //}
                //else if (Out.AmbassadorVisitCommand == id)
                //{
                //    sub.Out_AmbassadorVisitCommand(e);
                //}
                //else if (Out.AnswerPoll == id)
                //{
                //    sub.Out_AnswerPoll(e);
                //}
                //else if (Out.BotPickup == id)
                //{
                //    sub.Out_BotPickup(e);
                //}
                //else if (Out.BotPlace == id)
                //{
                //    sub.Out_BotPlace(e);
                //}
                //else if (Out.BotSaveSettings == id)
                //{
                //    sub.Out_BotSaveSettings(e);
                //}
                //else if (Out.BotSettings == id)
                //{
                //    sub.Out_BotSettings(e);
                //}
                //else if (Out.BreedPets == id)
                //{
                //    sub.Out_BreedPets(e);
                //}
                //else if (Out.BuyItem == id)
                //{
                //    sub.Out_BuyItem(e);
                //}
                //else if (Out.BuyRoomPromotion == id)
                //{
                //    sub.Out_BuyRoomPromotion(e);
                //}
                //else if (Out.CameraPublishToWeb == id)
                //{
                //    sub.Out_CameraPublishToWeb(e);
                //}
                //else if (Out.CameraPurchase == id)
                //{
                //    sub.Out_CameraPurchase(e);
                //}
                //else if (Out.CameraRoomPicture == id)
                //{
                //    sub.Out_CameraRoomPicture(e);
                //}
                //else if (Out.CameraRoomThumbnail == id)
                //{
                //    sub.Out_CameraRoomThumbnail(e);
                //}
                //else if (Out.CancelPoll == id)
                //{
                //    sub.Out_CancelPoll(e);
                //}
                else if (Out.CatalogBuyItem == id)
                {
                    sub.Out_CatalogBuyItem(e); 
                }
                //else if (Out.CatalogBuyItemAsGift == id)
                //{
                //    sub.Out_CatalogBuyItemAsGift(e);
                //}
                //else if (Out.CatalogSearchedItem == id)
                //{
                //    sub.Out_CatalogSearchedItem(e);
                //}
                //else if (Out.ChangeNameCheckUsername == id)
                //{
                //    sub.Out_ChangeNameCheckUsername(e);
                //}
                //else if (Out.ChangeRelation == id)
                //{
                //    sub.Out_ChangeRelation(e);
                //}
                //else if (Out.CheckPetName == id)
                //{
                //    sub.Out_CheckPetName(e);
                //}
                //else if (Out.ClientVariables == id)
                //{
                //    sub.Out_ClientVariables(e);
                //}
                else if (Out.CloseDice == id)
                {
                    sub.Out_CloseDice(e); 
                }
                //else if (Out.CompostMonsterplant == id)
                //{
                //    sub.Out_CompostMonsterplant(e);
                //}
                //else if (Out.ConfirmChangeName == id)
                //{
                //    sub.Out_ConfirmChangeName(e);
                //}
                //else if (Out.CraftingAddRecipe == id)
                //{
                //    sub.Out_CraftingAddRecipe(e);
                //}
                //else if (Out.CraftingCraftItem == id)
                //{
                //    sub.Out_CraftingCraftItem(e);
                //}
                //else if (Out.CraftingCraftSecret == id)
                //{
                //    sub.Out_CraftingCraftSecret(e);
                //}
                //else if (Out.DeclineFriendRequest == id)
                //{
                //    sub.Out_DeclineFriendRequest(e);
                //}
                //else if (Out.EditRoomPromotionMessage == id)
                //{
                //    sub.Out_EditRoomPromotionMessage(e);
                //}
                //else if (Out.EnableEffect == id)
                //{
                //    sub.Out_EnableEffect(e);
                //}
                //else if (Out.FindNewFriends == id)
                //{
                //    sub.Out_FindNewFriends(e);
                //}
                //else if (Out.FloorPlanEditorRequestBlockedTiles == id)
                //{
                //    sub.Out_FloorPlanEditorRequestBlockedTiles(e);
                //}
                //else if (Out.FloorPlanEditorRequestDoorSettings == id)
                //{
                //    sub.Out_FloorPlanEditorRequestDoorSettings(e);
                //}
                //else if (Out.FloorPlanEditorSave == id)
                //{
                //    sub.Out_FloorPlanEditorSave(e);
                //}
                //else if (Out.FootballGateSaveLook == id)
                //{
                //    sub.Out_FootballGateSaveLook(e);
                //}
                //else if (Out.FriendPrivateMessage == id)
                //{
                //    sub.Out_FriendPrivateMessage(e);
                //}
                //else if (Out.FriendRequest == id)
                //{
                //    sub.Out_FriendRequest(e);
                //}
                //else if (Out.GameCenter == id)
                //{
                //    sub.Out_GameCenter(e);
                //}
                //else if (Out.GameCenterJoinGame == id)
                //{
                //    sub.Out_GameCenterJoinGame(e);
                //}
                //else if (Out.GameCenterLoadGame == id)
                //{
                //    sub.Out_GameCenterLoadGame(e);
                //}
                //else if (Out.GameCenterRequestAccountStatus == id)
                //{
                //    sub.Out_GameCenterRequestAccountStatus(e);
                //}
                //else if (Out.GameCenterRequestGameStatus == id)
                //{
                //    sub.Out_GameCenterRequestGameStatus(e);
                //}
                //else if (Out.GenerateSecretKey == id)
                //{
                //    sub.Out_GenerateSecretKey(e);
                //}
                //else if (Out.GetClubData == id)
                //{
                //    sub.Out_GetClubData(e);
                //}
                //else if (Out.GetHabboGuildBadgesMessage == id)
                //{
                //    sub.Out_GetHabboGuildBadgesMessage(e);
                //}
                //else if (Out.GetMarketplaceConfig == id)
                //{
                //    sub.Out_GetMarketplaceConfig(e);
                //}
                //else if (Out.GetPollData == id)
                //{
                //    sub.Out_GetPollData(e);
                //}
                //else if (Out.GuardianAcceptRequest == id)
                //{
                //    sub.Out_GuardianAcceptRequest(e);
                //}
                //else if (Out.GuardianNoUpdatesWanted == id)
                //{
                //    sub.Out_GuardianNoUpdatesWanted(e);
                //}
                //else if (Out.GuardianVote == id)
                //{
                //    sub.Out_GuardianVote(e);
                //}
                //else if (Out.GuideCancelHelpRequest == id)
                //{
                //    sub.Out_GuideCancelHelpRequest(e);
                //}
                //else if (Out.GuideCloseHelpRequest == id)
                //{
                //    sub.Out_GuideCloseHelpRequest(e);
                //}
                //else if (Out.GuideHandleHelpRequest == id)
                //{
                //    sub.Out_GuideHandleHelpRequest(e);
                //}
                //else if (Out.GuideInviteUser == id)
                //{
                //    sub.Out_GuideInviteUser(e);
                //}
                //else if (Out.GuideRecommendHelper == id)
                //{
                //    sub.Out_GuideRecommendHelper(e);
                //}
                //else if (Out.GuideReportHelper == id)
                //{
                //    sub.Out_GuideReportHelper(e);
                //}
                //else if (Out.GuideUserMessage == id)
                //{
                //    sub.Out_GuideUserMessage(e);
                //}
                //else if (Out.GuideUserTyping == id)
                //{
                //    sub.Out_GuideUserTyping(e);
                //}
                //else if (Out.GuideVisitUser == id)
                //{
                //    sub.Out_GuideVisitUser(e);
                //}
                //else if (Out.GuildAcceptMembership == id)
                //{
                //    sub.Out_GuildAcceptMembership(e);
                //}
                //else if (Out.GuildChangeBadge == id)
                //{
                //    sub.Out_GuildChangeBadge(e);
                //}
                //else if (Out.GuildChangeColors == id)
                //{
                //    sub.Out_GuildChangeColors(e);
                //}
                //else if (Out.GuildChangeNameDesc == id)
                //{
                //    sub.Out_GuildChangeNameDesc(e);
                //}
                //else if (Out.GuildChangeSettings == id)
                //{
                //    sub.Out_GuildChangeSettings(e);
                //}
                //else if (Out.GuildConfirmRemoveMember == id)
                //{
                //    sub.Out_GuildConfirmRemoveMember(e);
                //}
                //else if (Out.GuildDeclineMembership == id)
                //{
                //    sub.Out_GuildDeclineMembership(e);
                //}
                //else if (Out.GuildDelete == id)
                //{
                //    sub.Out_GuildDelete(e);
                //}
                //else if (Out.GuildRemoveAdmin == id)
                //{
                //    sub.Out_GuildRemoveAdmin(e);
                //}
                //else if (Out.GuildRemoveFavorite == id)
                //{
                //    sub.Out_GuildRemoveFavorite(e);
                //}
                //else if (Out.GuildRemoveMember == id)
                //{
                //    sub.Out_GuildRemoveMember(e);
                //}
                //else if (Out.GuildSetAdmin == id)
                //{
                //    sub.Out_GuildSetAdmin(e);
                //}
                //else if (Out.GuildSetFavorite == id)
                //{
                //    sub.Out_GuildSetFavorite(e);
                //}
                //else if (Out.HandleDoorbell == id)
                //{
                //    sub.Out_HandleDoorbell(e);
                //}
                //else if (Out.HorseRide == id)
                //{
                //    sub.Out_HorseRide(e);
                //}
                //else if (Out.HorseRideSettings == id)
                //{
                //    sub.Out_HorseRideSettings(e);
                //}
                //else if (Out.HorseUseItem == id)
                //{
                //    sub.Out_HorseUseItem(e);
                //}
                //else if (Out.HotelView == id)
                //{
                //    sub.Out_HotelView(e);
                //}
                //else if (Out.HotelViewClaimBadge == id)
                //{
                //    sub.Out_HotelViewClaimBadge(e);
                //}
                //else if (Out.HotelViewClaimBadgeReward == id)
                //{
                //    sub.Out_HotelViewClaimBadgeReward(e);
                //}
                //else if (Out.HotelViewConcurrentUsersButton == id)
                //{
                //    sub.Out_HotelViewConcurrentUsersButton(e);
                //}
                //else if (Out.HotelViewData == id)
                //{
                //    sub.Out_HotelViewData(e);
                //}
                //else if (Out.HotelViewRequestBadgeReward == id)
                //{
                //    sub.Out_HotelViewRequestBadgeReward(e);
                //}
                //else if (Out.HotelViewRequestBonusRare == id)
                //{
                //    sub.Out_HotelViewRequestBonusRare(e);
                //}
                //else if (Out.HotelViewRequestCommunityGoal == id)
                //{
                //    sub.Out_HotelViewRequestCommunityGoal(e);
                //}
                //else if (Out.HotelViewRequestConcurrentUsers == id)
                //{
                //    sub.Out_HotelViewRequestConcurrentUsers(e);
                //}
                //else if (Out.IgnoreRoomUser == id)
                //{
                //    sub.Out_IgnoreRoomUser(e);
                //}
                //else if (Out.InitCrypto == id)
                //{
                //    sub.Out_InitCrypto(e);
                //}
                //else if (Out.InviteFriends == id)
                //{
                //    sub.Out_InviteFriends(e);
                //}
                //else if (Out.JukeBoxAddSoundTrack == id)
                //{
                //    sub.Out_JukeBoxAddSoundTrack(e);
                //}
                //else if (Out.JukeBoxEventOne == id)
                //{
                //    sub.Out_JukeBoxEventOne(e);
                //}
                //else if (Out.JukeBoxEventThree == id)
                //{
                //    sub.Out_JukeBoxEventThree(e);
                //}
                //else if (Out.JukeBoxEventTwo == id)
                //{
                //    sub.Out_JukeBoxEventTwo(e);
                //}
                //else if (Out.JukeBoxRequestPlayList == id)
                //{
                //    sub.Out_JukeBoxRequestPlayList(e);
                //}
                //else if (Out.JukeBoxRequestTrackCode == id)
                //{
                //    sub.Out_JukeBoxRequestTrackCode(e);
                //}
                //else if (Out.JukeBoxRequestTrackData == id)
                //{
                //    sub.Out_JukeBoxRequestTrackData(e);
                //}
                else if (Out.LatencyTest == id)
                {
                    sub.Out_LatencyTest(e); 
                }
                //else if (Out.MachineID == id)
                //{
                //    sub.Out_MachineID(e);
                //}
                //else if (Out.MannequinSaveLook == id)
                //{
                //    sub.Out_MannequinSaveLook(e);
                //}
                //else if (Out.MannequinSaveName == id)
                //{
                //    sub.Out_MannequinSaveName(e);
                //}
                //else if (Out.ModToolAlert == id)
                //{
                //    sub.Out_ModToolAlert(e);
                //}
                //else if (Out.ModToolBan == id)
                //{
                //    sub.Out_ModToolBan(e);
                //}
                //else if (Out.ModToolChangeRoomSettings == id)
                //{
                //    sub.Out_ModToolChangeRoomSettings(e);
                //}
                //else if (Out.ModToolCloseTicket == id)
                //{
                //    sub.Out_ModToolCloseTicket(e);
                //}
                //else if (Out.ModToolKick == id)
                //{
                //    sub.Out_ModToolKick(e);
                //}
                //else if (Out.ModToolPickTicket == id)
                //{
                //    sub.Out_ModToolPickTicket(e);
                //}
                //else if (Out.ModToolReleaseTicket == id)
                //{
                //    sub.Out_ModToolReleaseTicket(e);
                //}
                //else if (Out.ModToolRequestIssueChatlog == id)
                //{
                //    sub.Out_ModToolRequestIssueChatlog(e);
                //}
                //else if (Out.ModToolRequestRoomChatlog == id)
                //{
                //    sub.Out_ModToolRequestRoomChatlog(e);
                //}
                //else if (Out.ModToolRequestRoomInfo == id)
                //{
                //    sub.Out_ModToolRequestRoomInfo(e);
                //}
                //else if (Out.ModToolRequestRoomUserChatlog == id)
                //{
                //    sub.Out_ModToolRequestRoomUserChatlog(e);
                //}
                //else if (Out.ModToolRequestRoomVisits == id)
                //{
                //    sub.Out_ModToolRequestRoomVisits(e);
                //}
                //else if (Out.ModToolRequestUserChatlog == id)
                //{
                //    sub.Out_ModToolRequestUserChatlog(e);
                //}
                //else if (Out.ModToolRequestUserInfo == id)
                //{
                //    sub.Out_ModToolRequestUserInfo(e);
                //}
                //else if (Out.ModToolRoomAlert == id)
                //{
                //    sub.Out_ModToolRoomAlert(e);
                //}
                //else if (Out.ModToolSanctionAlert == id)
                //{
                //    sub.Out_ModToolSanctionAlert(e);
                //}
                //else if (Out.ModToolSanctionBan == id)
                //{
                //    sub.Out_ModToolSanctionBan(e);
                //}
                //else if (Out.ModToolSanctionMute == id)
                //{
                //    sub.Out_ModToolSanctionMute(e);
                //}
                //else if (Out.ModToolSanctionTradeLock == id)
                //{
                //    sub.Out_ModToolSanctionTradeLock(e);
                //}
                //else if (Out.ModToolWarn == id)
                //{
                //    sub.Out_ModToolWarn(e);
                //}
                //else if (Out.MoodLightSaveSettings == id)
                //{
                //    sub.Out_MoodLightSaveSettings(e);
                //}
                //else if (Out.MoodLightSettings == id)
                //{
                //    sub.Out_MoodLightSettings(e);
                //}
                //else if (Out.MoodLightTurnOn == id)
                //{
                //    sub.Out_MoodLightTurnOn(e);
                //}
                //else if (Out.MovePet == id)
                //{
                //    sub.Out_MovePet(e);
                //}
                else if (Out.MoveWallItem == id)
                {
                    sub.Out_MoveWallItem(e); 
                }
                //else if (Out.NavigatorCategoryListMode == id)
                //{
                //    sub.Out_NavigatorCategoryListMode(e);
                //}
                //else if (Out.NavigatorCollapseCategory == id)
                //{
                //    sub.Out_NavigatorCollapseCategory(e);
                //}
                //else if (Out.NavigatorUncollapseCategory == id)
                //{
                //    sub.Out_NavigatorUncollapseCategory(e);
                //}
                //else if (Out.NewNavigatorAction == id)
                //{
                //    sub.Out_NewNavigatorAction(e);
                //}
                //else if (Out.OpenRecycleBox == id)
                //{
                //    sub.Out_OpenRecycleBox(e);
                //}
                //else if (Out.PetPackageName == id)
                //{
                //    sub.Out_PetPackageName(e);
                //}
                //else if (Out.PetPickup == id)
                //{
                //    sub.Out_PetPickup(e);
                //}
                //else if (Out.PetPlace == id)
                //{
                //    sub.Out_PetPlace(e);
                //}
                //else if (Out.PickNewUserGift == id)
                //{
                //    sub.Out_PickNewUserGift(e);
                //}
                //else if (Out.Pong == id)
                //{
                //    sub.Out_Pong(e);
                //}
                //else if (Out.PostItDelete == id)
                //{
                //    sub.Out_PostItDelete(e);
                //}
                //else if (Out.PostItPlace == id)
                //{
                //    sub.Out_PostItPlace(e);
                //}
                //else if (Out.PostItRequestData == id)
                //{
                //    sub.Out_PostItRequestData(e);
                //}
                //else if (Out.PostItSaveData == id)
                //{
                //    sub.Out_PostItSaveData(e);
                //}
                //else if (Out.Recycle == id)
                //{
                //    sub.Out_Recycle(e);
                //}
                //else if (Out.RedeemClothing == id)
                //{
                //    sub.Out_RedeemClothing(e);
                //}
                //else if (Out.RedeemItem == id)
                //{
                //    sub.Out_RedeemItem(e);
                //}
                //else if (Out.RedeemVoucher == id)
                //{
                //    sub.Out_RedeemVoucher(e);
                //}
                //else if (Out.ReleaseVersion == id)
                //{
                //    sub.Out_ReleaseVersion(e);
                //}
                //else if (Out.ReloadRecycler == id)
                //{
                //    sub.Out_ReloadRecycler(e);
                //}
                else if (Out.RemoveFriend == id)
                {
                    sub.Out_RemoveFriend(e);
                }
                //else if (Out.RentSpace == id)
                //{
                //    sub.Out_RentSpace(e);
                //}
                //else if (Out.RentSpaceCancel == id)
                //{
                //    sub.Out_RentSpaceCancel(e);
                //}
                //else if (Out.Report == id)
                //{
                //    sub.Out_Report(e);
                //}
                //else if (Out.ReportBully == id)
                //{
                //    sub.Out_ReportBully(e);
                //}
                //else if (Out.RequestAchievementConfiguration == id)
                //{
                //    sub.Out_RequestAchievementConfiguration(e);
                //}
                //else if (Out.RequestAchievements == id)
                //{
                //    sub.Out_RequestAchievements(e);
                //}
                //else if (Out.RequestCameraConfiguration == id)
                //{
                //    sub.Out_RequestCameraConfiguration(e);
                //}
                //else if (Out.RequestCanCreateRoom == id)
                //{
                //    sub.Out_RequestCanCreateRoom(e);
                //}
                //else if (Out.RequestCatalogIndex == id)
                //{
                //    sub.Out_RequestCatalogIndex(e);
                //}
                //else if (Out.RequestCatalogMode == id)
                //{
                //    sub.Out_RequestCatalogMode(e);
                //}
                //else if (Out.RequestCatalogPage == id)
                //{
                //    sub.Out_RequestCatalogPage(e);
                //}
                //else if (Out.RequestClubGifts == id)
                //{
                //    sub.Out_RequestClubGifts(e);
                //}
                //else if (Out.RequestCraftingRecipes == id)
                //{
                //    sub.Out_RequestCraftingRecipes(e);
                //}
                //else if (Out.RequestCraftingRecipesAvailable == id)
                //{
                //    sub.Out_RequestCraftingRecipesAvailable(e);
                //}
                //else if (Out.RequestCreateRoom == id)
                //{
                //    sub.Out_RequestCreateRoom(e);
                //}
                //else if (Out.RequestCredits == id)
                //{
                //    sub.Out_RequestCredits(e);
                //}
                //else if (Out.RequestDeleteRoom == id)
                //{
                //    sub.Out_RequestDeleteRoom(e);
                //}
                //else if (Out.RequestDiscount == id)
                //{
                //    sub.Out_RequestDiscount(e);
                //}
                //else if (Out.RequestFriendRequest == id)
                //{
                //    sub.Out_RequestFriendRequest(e);
                //}
                //else if (Out.RequestFriends == id)
                //{
                //    sub.Out_RequestFriends(e);
                //}
                //else if (Out.RequestGameConfigurations == id)
                //{
                //    sub.Out_RequestGameConfigurations(e);
                //}
                //else if (Out.RequestGiftConfiguration == id)
                //{
                //    sub.Out_RequestGiftConfiguration(e);
                //}
                //else if (Out.RequestGuideAssistance == id)
                //{
                //    sub.Out_RequestGuideAssistance(e);
                //}
                //else if (Out.RequestGuideTool == id)
                //{
                //    sub.Out_RequestGuideTool(e);
                //}
                //else if (Out.RequestGuildBuy == id)
                //{
                //    sub.Out_RequestGuildBuy(e);
                //}
                //else if (Out.RequestGuildBuyRooms == id)
                //{
                //    sub.Out_RequestGuildBuyRooms(e);
                //}
                //else if (Out.RequestGuildFurniWidget == id)
                //{
                //    sub.Out_RequestGuildFurniWidget(e);
                //}
                //else if (Out.RequestGuildInfo == id)
                //{
                //    sub.Out_RequestGuildInfo(e);
                //}
                //else if (Out.RequestGuildJoin == id)
                //{
                //    sub.Out_RequestGuildJoin(e);
                //}
                //else if (Out.RequestGuildManage == id)
                //{
                //    sub.Out_RequestGuildManage(e);
                //}
                //else if (Out.RequestGuildMembers == id)
                //{
                //    sub.Out_RequestGuildMembers(e);
                //}
                //else if (Out.RequestGuildParts == id)
                //{
                //    sub.Out_RequestGuildParts(e);
                //}
                //else if (Out.RequestHeightmap == id)
                //{
                //    sub.Out_RequestHeightmap(e);
                //}
                //else if (Out.RequestHighestScoreRooms == id)
                //{
                //    sub.Out_RequestHighestScoreRooms(e);
                //}
                //else if (Out.RequestInitFriends == id)
                //{
                //    sub.Out_RequestInitFriends(e);
                //}
                //else if (Out.RequestInventoryBadges == id)
                //{
                //    sub.Out_RequestInventoryBadges(e);
                //}
                //else if (Out.RequestInventoryBots == id)
                //{
                //    sub.Out_RequestInventoryBots(e);
                //}
                //else if (Out.RequestInventoryItems == id)
                //{
                //    sub.Out_RequestInventoryItems(e);
                //}
                //else if (Out.RequestInventoryPets == id)
                //{
                //    sub.Out_RequestInventoryPets(e);
                //}
                //else if (Out.RequestItemInfo == id)
                //{
                //    sub.Out_RequestItemInfo(e);
                //}
                //else if (Out.RequestMeMenuSettings == id)
                //{
                //    sub.Out_RequestMeMenuSettings(e);
                //}
                //else if (Out.RequestMyRooms == id)
                //{
                //    sub.Out_RequestMyRooms(e);
                //}
                //else if (Out.RequestNavigatorSettings == id)
                //{
                //    sub.Out_RequestNavigatorSettings(e);
                //}
                //else if (Out.RequestNewNavigatorData == id)
                //{
                //    sub.Out_RequestNewNavigatorData(e);
                //}
                //else if (Out.RequestNewNavigatorRooms == id)
                //{
                //    sub.Out_RequestNewNavigatorRooms(e);
                //}
                //else if (Out.RequestNewsList == id)
                //{
                //    sub.Out_RequestNewsList(e);
                //}
                //else if (Out.RequestOffers == id)
                //{
                //    sub.Out_RequestOffers(e);
                //}
                //else if (Out.RequestOwnGuilds == id)
                //{
                //    sub.Out_RequestOwnGuilds(e);
                //}
                //else if (Out.RequestOwnItems == id)
                //{
                //    sub.Out_RequestOwnItems(e);
                //}
                //else if (Out.RequestPetBreeds == id)
                //{
                //    sub.Out_RequestPetBreeds(e);
                //}
                //else if (Out.RequestPetInfo == id)
                //{
                //    sub.Out_RequestPetInfo(e);
                //}
                //else if (Out.RequestPetTrainingPanel == id)
                //{
                //    sub.Out_RequestPetTrainingPanel(e);
                //}
                //else if (Out.RequestPopularRooms == id)
                //{
                //    sub.Out_RequestPopularRooms(e);
                //}
                //else if (Out.RequestProfileFriends == id)
                //{
                //    sub.Out_RequestProfileFriends(e);
                //}
                //else if (Out.RequestPromotedRooms == id)
                //{
                //    sub.Out_RequestPromotedRooms(e);
                //}
                //else if (Out.RequestPromotionRooms == id)
                //{
                //    sub.Out_RequestPromotionRooms(e);
                //}
                //else if (Out.RequestPublicRooms == id)
                //{
                //    sub.Out_RequestPublicRooms(e);
                //}
                //else if (Out.RequestRecylerLogic == id)
                //{
                //    sub.Out_RequestRecylerLogic(e);
                //}
                //else if (Out.RequestReportRoom == id)
                //{
                //    sub.Out_RequestReportRoom(e);
                //}
                //else if (Out.RequestReportUserBullying == id)
                //{
                //    sub.Out_RequestReportUserBullying(e);
                //}
                //else if (Out.RequestResolution == id)
                //{
                //    sub.Out_RequestResolution(e);
                //}
                //else if (Out.RequestRoomCategories == id)
                //{
                //    sub.Out_RequestRoomCategories(e);
                //}
                else if (Out.RequestRoomData == id)
                {
                    sub.Out_RequestRoomData(e);
                }
                else if (Out.RequestRoomHeightmap == id)
                {
                    sub.Out_RequestRoomHeightmap(e);
                }
                else if (Out.RequestRoomLoad == id)
                {
                    sub.Out_RequestRoomLoad(e); 
                }
                //else if (Out.RequestRoomRights == id)
                //{
                //    sub.Out_RequestRoomRights(e);
                //}
                //else if (Out.RequestRoomSettings == id)
                //{
                //    sub.Out_RequestRoomSettings(e);
                //}
                //else if (Out.RequestRoomWordFilter == id)
                //{
                //    sub.Out_RequestRoomWordFilter(e);
                //}
                //else if (Out.RequestSellItem == id)
                //{
                //    sub.Out_RequestSellItem(e);
                //}
                //else if (Out.RequestTags == id)
                //{
                //    sub.Out_RequestTags(e);
                //}
                //else if (Out.RequestTalenTrack == id)
                //{
                //    sub.Out_RequestTalenTrack(e);
                //}
                //else if (Out.RequestTargetOffer == id)
                //{
                //    sub.Out_RequestTargetOffer(e);
                //}
                //else if (Out.RequestUserCitizinShip == id)
                //{
                //    sub.Out_RequestUserCitizinShip(e);
                //}
                //else if (Out.RequestUserClub == id)
                //{
                //    sub.Out_RequestUserClub(e);
                //}
                //else if (Out.RequestUserCredits == id)
                //{
                //    sub.Out_RequestUserCredits(e);
                //}
                //else if (Out.RequestUserData == id)
                //{
                //    sub.Out_RequestUserData(e);
                //}
                //else if (Out.RequestUserProfile == id)
                //{
                //    sub.Out_RequestUserProfile(e);
                //}
                //else if (Out.RequestUserTags == id)
                //{
                //    sub.Out_RequestUserTags(e);
                //}
                //else if (Out.RequestUserWardrobe == id)
                //{
                //    sub.Out_RequestUserWardrobe(e);
                //}
                else if (Out.RequestWearingBadges == id)
                {
                    sub.Out_RequestWearingBadges(e); 
                }
                else if (Out.RoomBackground == id)
                {
                    sub.Out_RoomBackground(e);
                }
                //else if (Out.RoomFavorite == id)
                //{
                //    sub.Out_RoomFavorite(e);
                //}
                //else if (Out.RoomMute == id)
                //{
                //    sub.Out_RoomMute(e);
                //}
                else if (Out.RoomPickupItem == id)
                {
                    sub.Out_RoomPickupItem(e); 
                }
                //else if (Out.RoomPlaceBuildersClubItem == id)
                //{
                //    sub.Out_RoomPlaceBuildersClubItem(e);
                //}
                else if (Out.RoomPlaceItem == id)
                {
                    sub.Out_RoomPlaceItem(e);
                }
                //else if (Out.RoomPlacePaint == id)
                //{
                //    sub.Out_RoomPlacePaint(e);
                //}
                //else if (Out.RoomRemoveAllRights == id)
                //{
                //    sub.Out_RoomRemoveAllRights(e);
                //}
                //else if (Out.RoomRemoveRights == id)
                //{
                //    sub.Out_RoomRemoveRights(e);
                //}
                //else if (Out.RoomRequestBannedUsers == id)
                //{
                //    sub.Out_RoomRequestBannedUsers(e);
                //}
                //else if (Out.RoomSettingsSave == id)
                //{
                //    sub.Out_RoomSettingsSave(e);
                //}
                //else if (Out.RoomStaffPick == id)
                //{
                //    sub.Out_RoomStaffPick(e);
                //}
                //else if (Out.RoomUserAction == id)
                //{
                //    sub.Out_RoomUserAction(e);
                //}
                //else if (Out.RoomUserBan == id)
                //{
                //    sub.Out_RoomUserBan(e);
                //}
                //else if (Out.RoomUserDance == id)
                //{
                //    sub.Out_RoomUserDance(e);
                //}
                //else if (Out.RoomUserDropHandItem == id)
                //{
                //    sub.Out_RoomUserDropHandItem(e);
                //}
                //else if (Out.RoomUserGiveHandItem == id)
                //{
                //    sub.Out_RoomUserGiveHandItem(e);
                //}
                //else if (Out.RoomUserGiveRespect == id)
                //{
                //    sub.Out_RoomUserGiveRespect(e);
                //}
                //else if (Out.RoomUserGiveRights == id)
                //{
                //    sub.Out_RoomUserGiveRights(e);
                //}
                //else if (Out.RoomUserKick == id)
                //{
                //    sub.Out_RoomUserKick(e);
                //}
                //else if (Out.RoomUserLookAtPoint == id)
                //{
                //    sub.Out_RoomUserLookAtPoint(e);
                //}
                //else if (Out.RoomUserMute == id)
                //{
                //    sub.Out_RoomUserMute(e);
                //}
                //else if (Out.RoomUserRemoveRights == id)
                //{
                //    sub.Out_RoomUserRemoveRights(e);
                //}
                else if (Out.RoomUserShout == id)
                {
                    sub.Out_RoomUserShout(e); 
                }
                //else if (Out.RoomUserSign == id)
                //{
                //    sub.Out_RoomUserSign(e);
                //}
                //else if (Out.RoomUserSit == id)
                //{
                //    sub.Out_RoomUserSit(e);
                //}
                else if (Out.RoomUserStartTyping == id)
                {
                    sub.Out_RoomUserStartTyping(e); 
                }
                //else if (Out.RoomUserStopTyping == id)
                //{
                //    sub.Out_RoomUserStopTyping(e);
                //}
                else if (Out.RoomUserTalk == id)
                {
                    sub.Out_RoomUserTalk(e); 
                }
                else if (Out.RoomUserWalk == id)
                {
                    sub.Out_RoomUserWalk(e);  
                }
                else if (Out.RoomUserWhisper == id)
                {
                    sub.Out_RoomUserWhisper(e); //used
                }
                //else if (Out.RoomVote == id)
                //{
                //    sub.Out_RoomVote(e);
                //}
                //else if (Out.RoomWordFilterModify == id)
                //{
                //    sub.Out_RoomWordFilterModify(e);
                //}
                else if (Out.RotateMoveItem == id)
                {
                    sub.Out_RotateMoveItem(e); 
                }
                //else if (Out.SSOTicket == id)
                //{
                //    sub.Out_SSOTicket(e);
                //}
                //else if (Out.SaveBlockCameraFollow == id)
                //{
                //    sub.Out_SaveBlockCameraFollow(e);
                //}
                //else if (Out.SaveIgnoreRoomInvites == id)
                //{
                //    sub.Out_SaveIgnoreRoomInvites(e);
                //}
                //else if (Out.SaveMotto == id)
                //{
                //    sub.Out_SaveMotto(e);
                //}
                //else if (Out.SavePostItStickyPole == id)
                //{
                //    sub.Out_SavePostItStickyPole(e);
                //}
                //else if (Out.SavePreferOldChat == id)
                //{
                //    sub.Out_SavePreferOldChat(e);
                //}
                //else if (Out.SaveUserVolumes == id)
                //{
                //    sub.Out_SaveUserVolumes(e);
                //}
                //else if (Out.SaveWardrobe == id)
                //{
                //    sub.Out_SaveWardrobe(e);
                //}
                //else if (Out.SaveWindowSettings == id)
                //{
                //    sub.Out_SaveWindowSettings(e);
                //}
                //else if (Out.ScratchPet == id)
                //{
                //    sub.Out_ScratchPet(e);
                //}
                //else if (Out.SearchRooms == id)
                //{
                //    sub.Out_SearchRooms(e);
                //}
                //else if (Out.SearchRoomsByTag == id)
                //{
                //    sub.Out_SearchRoomsByTag(e);
                //}
                //else if (Out.SearchRoomsFriendsNow == id)
                //{
                //    sub.Out_SearchRoomsFriendsNow(e);
                //}
                //else if (Out.SearchRoomsFriendsOwn == id)
                //{
                //    sub.Out_SearchRoomsFriendsOwn(e);
                //}
                //else if (Out.SearchRoomsInGroup == id)
                //{
                //    sub.Out_SearchRoomsInGroup(e);
                //}
                //else if (Out.SearchRoomsMyFavorite == id)
                //{
                //    sub.Out_SearchRoomsMyFavorite(e);
                //}
                //else if (Out.SearchRoomsVisited == id)
                //{
                //    sub.Out_SearchRoomsVisited(e);
                //}
                //else if (Out.SearchRoomsWithRights == id)
                //{
                //    sub.Out_SearchRoomsWithRights(e);
                //}
                //else if (Out.SearchUser == id)
                //{
                //    sub.Out_SearchUser(e);
                //}
                //else if (Out.SellItem == id)
                //{
                //    sub.Out_SellItem(e);
                //}
                //else if (Out.SetHomeRoom == id)
                //{
                //    sub.Out_SetHomeRoom(e);
                //}
                //else if (Out.SetStackHelperHeight == id)
                //{
                //    sub.Out_SetStackHelperHeight(e);
                //}
                //else if (Out.StalkFriend == id)
                //{
                //    sub.Out_StalkFriend(e);
                //}
                //else if (Out.TakeBackItem == id)
                //{
                //    sub.Out_TakeBackItem(e);
                //}
                //else if (Out.TestInventory == id)
                //{
                //    sub.Out_TestInventory(e);
                //}
                else if (Out.ToggleFloorItem == id)
                {
                    sub.Out_ToggleFloorItem(e);
                }
                //else if (Out.ToggleMonsterplantBreedable == id)
                //{
                //    sub.Out_ToggleMonsterplantBreedable(e);
                //}
                else if (Out.ToggleWallItem == id)
                {
                    sub.Out_ToggleWallItem(e);
                }
                //else if (Out.TradeAccept == id)
                //{
                //    sub.Out_TradeAccept(e);
                //}
                //else if (Out.TradeCancelOfferItem == id)
                //{
                //    sub.Out_TradeCancelOfferItem(e);
                //}
                //else if (Out.TradeClose == id)
                //{
                //    sub.Out_TradeClose(e);
                //}
                //else if (Out.TradeConfirm == id)
                //{
                //    sub.Out_TradeConfirm(e);
                //}
                //else if (Out.TradeOfferItem == id)
                //{
                //    sub.Out_TradeOfferItem(e);
                //}
                //else if (Out.TradeOfferMultipleItems == id)
                //{
                //    sub.Out_TradeOfferMultipleItems(e);
                //}
                else if (Out.TradeStart == id)
                {
                    sub.Out_TradeStart(e);
                }
                //else if (Out.TradeUnAccept == id)
                //{
                //    sub.Out_TradeUnAccept(e);
                //}
                else if (Out.TriggerColorWheel == id)
                {
                    sub.Out_TriggerColorWheel(e);
                }
                else if (Out.TriggerDice == id)
                {
                    sub.Out_TriggerDice(e); 
                }
                //else if (Out.TriggerOneWayGate == id)
                //{
                //    sub.Out_TriggerOneWayGate(e);
                //}
                //else if (Out.UnIgnoreRoomUser == id)
                //{
                //    sub.Out_UnIgnoreRoomUser(e);
                //}
                //else if (Out.UnbanRoomUser == id)
                //{
                //    sub.Out_UnbanRoomUser(e);
                //}
                //else if (Out.UserActivity == id)
                //{
                //    sub.Out_UserActivity(e);
                //}
                //else if (Out.UserNux == id)
                //{
                //    sub.Out_UserNux(e);
                //}
                //else if (Out.UserSaveLook == id)
                //{
                //    sub.Out_UserSaveLook(e);
                //}
                //else if (Out.UserWearBadge == id)
                //{
                //    sub.Out_UserWearBadge(e);
                //}
                else if (Out.Username == id)
                {
                    sub.Out_Username(e); 
                }
                //else if (Out.WiredConditionSaveData == id)
                //{
                //    sub.Out_WiredConditionSaveData(e);
                //}
                //else if (Out.WiredEffectSaveData == id)
                //{
                //    sub.Out_WiredEffectSaveData(e);
                //}
                //else if (Out.WiredTriggerSaveData == id)
                //{
                //    sub.Out_WiredTriggerSaveData(e);
                //}
                //else if (Out.YoutubeRequestNextVideo == id)
                //{
                //    sub.Out_YoutubeRequestNextVideo(e);
                //}
                //else if (Out.YoutubeRequestPlayList == id)
                //{
                //    sub.Out_YoutubeRequestPlayList(e);
                //}
                //else if (Out.YoutubeRequestVideoData == id)
                //{
                //    sub.Out_YoutubeRequestVideoData(e);
                //}
            }
        }

        public override void HandleIncoming(DataInterceptedEventArgs e)
        {
            int id = e.Packet.Header;
            foreach (var sub in _subscribers)
            {
                e.Packet.Position = 0;
                if (In.AddFloorItem == id)
                {
                    sub.In_AddFloorItem(e);
                }
                //else if (In.AddHabboItem == id)
                //{
                //    sub.In_AddHabboItem(e);
                //}
                //else if (In.AddPet == id)
                //{
                //    sub.In_AddPet(e);
                //}
                //else if (In.AddUserBadge == id)
                //{
                //    sub.In_AddUserBadge(e);
                //}
                else if (In.AddWallItem == id)
                {
                    sub.In_AddWallItem(e);
                }
                //else (In.AchievementList == id)
                //{
                //    sub.In_AchievementList(e);
                //}
                //else if (In.AchievementProgress == id)
                //{
                //    sub.In_AchievementProgress(e);
                //}
                //else if (In.AchievementUnlocked == id)
                //{
                //    sub.In_AchievementUnlocked(e);
                //}
                //else if (In.AchievementsConfiguration == id)
                //{
                //    sub.In_AchievementsConfiguration(e);
                //}
                //else if (In.AddBot == id)
                //{
                //    sub.In_AddBot(e);
                //}
                //else if (In.AdventCalendarData == id)
                //{
                //    sub.In_AdventCalendarData(e);
                //}
                //else if (In.AdventCalendarProduct == id)
                //{
                //    sub.In_AdventCalendarProduct(e);
                //}
                //else if (In.AlertLimitedSoldOut == id)
                //{
                //    sub.In_AlertLimitedSoldOut(e);
                //}
                //else if (In.AlertPurchaseFailed == id)
                //{
                //    sub.In_AlertPurchaseFailed(e);
                //}
                //else if (In.AlertPurchaseUnavailable == id)
                //{
                //    sub.In_AlertPurchaseUnavailable(e);
                //}
                //else if (In.BaseJumpJoinQueue == id)
                //{
                //    sub.In_BaseJumpJoinQueue(e);
                //}
                //else if (In.BaseJumpLeaveQueue == id)
                //{
                //    sub.In_BaseJumpLeaveQueue(e);
                //}
                //else if (In.BaseJumpLoadGame == id)
                //{
                //    sub.In_BaseJumpLoadGame(e);
                //}
                //else if (In.BaseJumpLoadGameURL == id)
                //{
                //    sub.In_BaseJumpLoadGameURL(e);
                //}
                //else if (In.BaseJumpUnloadGame == id)
                //{
                //    sub.In_BaseJumpUnloadGame(e);
                //}
                //else if (In.BonusRare == id)
                //{
                //    sub.In_BonusRare(e);
                //}
                //else if (In.BotError == id)
                //{
                //    sub.In_BotError(e);
                //}
                //else if (In.BotSettings == id)
                //{
                //    sub.In_BotSettings(e);
                //}
                //else if (In.BubbleAlert == id)
                //{
                //    sub.In_BubbleAlert(e);
                //}
                //else if (In.BuildersClubExpired == id)
                //{
                //    sub.In_BuildersClubExpired(e);
                //}
                //else if (In.BullyReportClosed == id)
                //{
                //    sub.In_BullyReportClosed(e);
                //}
                //else if (In.BullyReportRequest == id)
                //{
                //    sub.In_BullyReportRequest(e);
                //}
                //else if (In.BullyReportedMessage == id)
                //{
                //    sub.In_BullyReportedMessage(e);
                //}
                //else if (In.CameraCompetitionStatus == id)
                //{
                //    sub.In_CameraCompetitionStatus(e);
                //}
                //else if (In.CameraPrice == id)
                //{
                //    sub.In_CameraPrice(e);
                //}
                //else if (In.CameraPublishWaitMessage == id)
                //{
                //    sub.In_CameraPublishWaitMessage(e);
                //}
                //else if (In.CameraPurchaseSuccesfull == id)
                //{
                //    sub.In_CameraPurchaseSuccesfull(e);
                //}
                //else if (In.CameraRoomThumbnailSaved == id)
                //{
                //    sub.In_CameraRoomThumbnailSaved(e);
                //}
                //else if (In.CameraURL == id)
                //{
                //    sub.In_CameraURL(e);
                //}
                //else if (In.CanCreateEvent == id)
                //{
                //    sub.In_CanCreateEvent(e);
                //}
                //else if (In.CanCreateRoom == id)
                //{
                //    sub.In_CanCreateRoom(e);
                //}
                //else if (In.CantScratchPetNotOldEnough == id)
                //{
                //    sub.In_CantScratchPetNotOldEnough(e);
                //}
                //else if (In.CatalogMode == id)
                //{
                //    sub.In_CatalogMode(e);
                //}
                //else if (In.CatalogPage == id)
                //{
                //    sub.In_CatalogPage(e);
                //}
                //else if (In.CatalogPagesList == id)
                //{
                //    sub.In_CatalogPagesList(e);
                //}
                //else if (In.CatalogSearchResult == id)
                //{
                //    sub.In_CatalogSearchResult(e);
                //}
                //else if (In.CatalogUpdated == id)
                //{
                //    sub.In_CatalogUpdated(e);
                //}
                //else if (In.CfhTopicsMessage == id)
                //{
                //    sub.In_CfhTopicsMessage(e);
                //}
                //else if (In.ChangeNameUpdate == id)
                //{
                //    sub.In_ChangeNameUpdate(e);
                //}
                //else if (In.CloseWebPage == id)
                //{
                //    sub.In_CloseWebPage(e);
                //}
                //else if (In.ClubCenterData == id)
                //{
                //    sub.In_ClubCenterData(e);
                //}
                //else if (In.ClubData == id)
                //{
                //    sub.In_ClubData(e);
                //}
                //else if (In.ClubGiftReceived == id)
                //{
                //    sub.In_ClubGiftReceived(e);
                //}
                //else if (In.ClubGifts == id)
                //{
                //    sub.In_ClubGifts(e);
                //}
                //else if (In.CompetitionEntrySubmitResult == id)
                //{
                //    sub.In_CompetitionEntrySubmitResult(e);
                //}
                //else if (In.ConnectionError == id)
                //{
                //    sub.In_ConnectionError(e);
                //}
                //else if (In.ConvertedForwardToRoom == id)
                //{
                //    sub.In_ConvertedForwardToRoom(e);
                //}
                //else if (In.CraftableProducts == id)
                //{
                //    sub.In_CraftableProducts(e);
                //}
                //else if (In.CraftingComposerFour == id)
                //{
                //    sub.In_CraftingComposerFour(e);
                //}
                //else if (In.CraftingRecipe == id)
                //{
                //    sub.In_CraftingRecipe(e);
                //}
                //else if (In.CraftingResult == id)
                //{
                //    sub.In_CraftingResult(e);
                //}
                //else if (In.CustomNotification == id)
                //{
                //    sub.In_CustomNotification(e);
                //}
                //else if (In.DailyQuest == id)
                //{
                //    sub.In_DailyQuest(e);
                //}
                //else if (In.DebugConsole == id)
                //{
                //    sub.In_DebugConsole(e);
                //}
                //else if (In.Discount == id)
                //{
                //    sub.In_Discount(e);
                //}
                //else if (In.DoorbellAddUser == id)
                //{
                //    sub.In_DoorbellAddUser(e);
                //}
                //else if (In.EffectsListAdd == id)
                //{
                //    sub.In_EffectsListAdd(e);
                //}
                //else if (In.EffectsListEffectEnable == id)
                //{
                //    sub.In_EffectsListEffectEnable(e);
                //}
                //else if (In.EffectsListRemove == id)
                //{
                //    sub.In_EffectsListRemove(e);
                //}
                //else if (In.EpicPopupFrame == id)
                //{
                //    sub.In_EpicPopupFrame(e);
                //}
                //else if (In.ErrorLogin == id)
                //{
                //    sub.In_ErrorLogin(e);
                //}
                //else if (In.ExtendClubMessage == id)
                //{
                //    sub.In_ExtendClubMessage(e);
                //}
                //else if (In.FavoriteRoomChanged == id)
                //{
                //    sub.In_FavoriteRoomChanged(e);
                //}
                //else if (In.FavoriteRoomsCount == id)
                //{
                //    sub.In_FavoriteRoomsCount(e);
                //}
                //else if (In.FloodCounter == id)
                //{
                //    sub.In_FloodCounter(e);
                //}
                else if (In.FloorItemUpdate == id)
                {
                    sub.In_FloorItemUpdate(e);
                }
                //else if (In.FloorPlanEditorBlockedTiles == id)
                //{
                //    sub.In_FloorPlanEditorBlockedTiles(e);
                //}
                //else if (In.FloorPlanEditorDoorSettings == id)
                //{
                //    sub.In_FloorPlanEditorDoorSettings(e);
                //}
                //else if (In.ForwardToRoom == id)
                //{
                //    sub.In_ForwardToRoom(e);
                //}
                //else if (In.FreezeLives == id)
                //{
                //    sub.In_FreezeLives(e);
                //}
                //else if (In.FriendChatMessage == id)
                //{
                //    sub.In_FriendChatMessage(e);
                //}
                //else if (In.FriendFindingRoom == id)
                //{
                //    sub.In_FriendFindingRoom(e);
                //}
                //else if (In.FriendRequest == id)
                //{
                //    sub.In_FriendRequest(e);
                //}
                //else if (In.FriendRequestError == id)
                //{
                //    sub.In_FriendRequestError(e);
                //}
                //else if (In.FriendToolbarNotification == id)
                //{
                //    sub.In_FriendToolbarNotification(e);
                //}
                //else if (In.Friends == id)
                //{
                //    sub.In_Friends(e);
                //}
                //else if (In.Game2WeeklyLeaderboard == id)
                //{
                //    sub.In_Game2WeeklyLeaderboard(e);
                //}
                //else if (In.Game2WeeklySmallLeaderboard == id)
                //{
                //    sub.In_Game2WeeklySmallLeaderboard(e);
                //}
                //else if (In.GameAchievementsList == id)
                //{
                //    sub.In_GameAchievementsList(e);
                //}
                //else if (In.GameCenterAccountInfo == id)
                //{
                //    sub.In_GameCenterAccountInfo(e);
                //}
                //else if (In.GameCenterFeaturedPlayers == id)
                //{
                //    sub.In_GameCenterFeaturedPlayers(e);
                //}
                //else if (In.GameCenterGame == id)
                //{
                //    sub.In_GameCenterGame(e);
                //}
                //else if (In.GameCenterGameList == id)
                //{
                //    sub.In_GameCenterGameList(e);
                //}
                //else if (In.GenerateSecretKey == id)
                //{
                //    sub.In_GenerateSecretKey(e);
                //}
                //else if (In.GenericAlert == id)
                //{
                //    sub.In_GenericAlert(e);
                //}
                else if (In.GenericErrorMessages == id)
                {
                    sub.In_GenericErrorMessages(e);
                }
                //else if (In.GiftConfiguration == id)
                //{
                //    sub.In_GiftConfiguration(e);
                //}
                //else if (In.GiftReceiverNotFound == id)
                //{
                //    sub.In_GiftReceiverNotFound(e);
                //}
                //else if (In.GroupParts == id)
                //{
                //    sub.In_GroupParts(e);
                //}
                //else if (In.GuardianNewReportReceived == id)
                //{
                //    sub.In_GuardianNewReportReceived(e);
                //}
                //else if (In.GuardianVotingRequested == id)
                //{
                //    sub.In_GuardianVotingRequested(e);
                //}
                //else if (In.GuardianVotingResult == id)
                //{
                //    sub.In_GuardianVotingResult(e);
                //}
                //else if (In.GuardianVotingTimeEnded == id)
                //{
                //    sub.In_GuardianVotingTimeEnded(e);
                //}
                //else if (In.GuardianVotingVotes == id)
                //{
                //    sub.In_GuardianVotingVotes(e);
                //}
                //else if (In.GuideSessionAttached == id)
                //{
                //    sub.In_GuideSessionAttached(e);
                //}
                //else if (In.GuideSessionDetached == id)
                //{
                //    sub.In_GuideSessionDetached(e);
                //}
                //else if (In.GuideSessionEnded == id)
                //{
                //    sub.In_GuideSessionEnded(e);
                //}
                //else if (In.GuideSessionError == id)
                //{
                //    sub.In_GuideSessionError(e);
                //}
                //else if (In.GuideSessionInvitedToGuideRoom == id)
                //{
                //    sub.In_GuideSessionInvitedToGuideRoom(e);
                //}
                //else if (In.GuideSessionMessage == id)
                //{
                //    sub.In_GuideSessionMessage(e);
                //}
                //else if (In.GuideSessionPartnerIsPlaying == id)
                //{
                //    sub.In_GuideSessionPartnerIsPlaying(e);
                //}
                //else if (In.GuideSessionPartnerIsTyping == id)
                //{
                //    sub.In_GuideSessionPartnerIsTyping(e);
                //}
                //else if (In.GuideSessionRequesterRoom == id)
                //{
                //    sub.In_GuideSessionRequesterRoom(e);
                //}
                //else if (In.GuideSessionStarted == id)
                //{
                //    sub.In_GuideSessionStarted(e);
                //}
                //else if (In.GuideTools == id)
                //{
                //    sub.In_GuideTools(e);
                //}
                //else if (In.GuildAcceptMemberError == id)
                //{
                //    sub.In_GuildAcceptMemberError(e);
                //}
                //else if (In.GuildBought == id)
                //{
                //    sub.In_GuildBought(e);
                //}
                //else if (In.GuildBuyRooms == id)
                //{
                //    sub.In_GuildBuyRooms(e);
                //}
                //else if (In.GuildConfirmRemoveMember == id)
                //{
                //    sub.In_GuildConfirmRemoveMember(e);
                //}
                //else if (In.GuildEditFail == id)
                //{
                //    sub.In_GuildEditFail(e);
                //}
                //else if (In.GuildFavoriteRoomUserUpdate == id)
                //{
                //    sub.In_GuildFavoriteRoomUserUpdate(e);
                //}
                //else if (In.GuildForumAddComment == id)
                //{
                //    sub.In_GuildForumAddComment(e);
                //}
                //else if (In.GuildForumComments == id)
                //{
                //    sub.In_GuildForumComments(e);
                //}
                //else if (In.GuildForumData == id)
                //{
                //    sub.In_GuildForumData(e);
                //}
                //else if (In.GuildForumList == id)
                //{
                //    sub.In_GuildForumList(e);
                //}
                //else if (In.GuildForumThreadMessages == id)
                //{
                //    sub.In_GuildForumThreadMessages(e);
                //}
                //else if (In.GuildForumThreads == id)
                //{
                //    sub.In_GuildForumThreads(e);
                //}
                //else if (In.GuildForumsUnreadMessagesCount == id)
                //{
                //    sub.In_GuildForumsUnreadMessagesCount(e);
                //}
                //else if (In.GuildFurniWidget == id)
                //{
                //    sub.In_GuildFurniWidget(e);
                //}
                //else if (In.GuildInfo == id)
                //{
                //    sub.In_GuildInfo(e);
                //}
                //else if (In.GuildJoinError == id)
                //{
                //    sub.In_GuildJoinError(e);
                //}
                //else if (In.GuildList == id)
                //{
                //    sub.In_GuildList(e);
                //}
                //else if (In.GuildManage == id)
                //{
                //    sub.In_GuildManage(e);
                //}
                //else if (In.GuildMemberUpdate == id)
                //{
                //    sub.In_GuildMemberUpdate(e);
                //}
                //else if (In.GuildMembers == id)
                //{
                //    sub.In_GuildMembers(e);
                //}
                //else if (In.GuildRefreshMembersList == id)
                //{
                //    sub.In_GuildRefreshMembersList(e);
                //}
                //else if (In.HabboMall == id)
                //{
                //    sub.In_HabboMall(e);
                //}
                //else if (In.HabboWayQuizComposer1 == id)
                //{
                //    sub.In_HabboWayQuizComposer1(e);
                //}
                //else if (In.HabboWayQuizComposer2 == id)
                //{
                //    sub.In_HabboWayQuizComposer2(e);
                //}
                //else if (In.HallOfFame == id)
                //{
                //    sub.In_HallOfFame(e);
                //}
                //else if (In.HelperRequestDisabled == id)
                //{
                //    sub.In_HelperRequestDisabled(e);
                //}
                //else if (In.HideDoorbell == id)
                //{
                //    sub.In_HideDoorbell(e);
                //}
                //else if (In.HotelClosedAndOpens == id)
                //{
                //    sub.In_HotelClosedAndOpens(e);
                //}
                //else if (In.HotelClosesAndWillOpenAt == id)
                //{
                //    sub.In_HotelClosesAndWillOpenAt(e);
                //}
                else if (In.HotelView == id)
                {
                    sub.In_HotelView(e);
                }
                //else if (In.HotelViewBadgeButtonConfig == id)
                //{
                //    sub.In_HotelViewBadgeButtonConfig(e);
                //}
                //else if (In.HotelViewCatalogPageExpiring == id)
                //{
                //    sub.In_HotelViewCatalogPageExpiring(e);
                //}
                //else if (In.HotelViewCommunityGoal == id)
                //{
                //    sub.In_HotelViewCommunityGoal(e);
                //}
                //else if (In.HotelViewConcurrentUsers == id)
                //{
                //    sub.In_HotelViewConcurrentUsers(e);
                //}
                //else if (In.HotelViewCustomTimer == id)
                //{
                //    sub.In_HotelViewCustomTimer(e);
                //}
                //else if (In.HotelViewData == id)
                //{
                //    sub.In_HotelViewData(e);
                //}
                //else if (In.HotelViewExpiringCatalogPageCommposer == id)
                //{
                //    sub.In_HotelViewExpiringCatalogPageCommposer(e);
                //}
                //else if (In.HotelViewHideCommunityVoteButton == id)
                //{
                //    sub.In_HotelViewHideCommunityVoteButton(e);
                //}
                //else if (In.HotelViewNextLTDAvailable == id)
                //{
                //    sub.In_HotelViewNextLTDAvailable(e);
                //}
                //else if (In.HotelWillCloseInMinutes == id)
                //{
                //    sub.In_HotelWillCloseInMinutes(e);
                //}
                //else if (In.HotelWillCloseInMinutesAndBackIn == id)
                //{
                //    sub.In_HotelWillCloseInMinutesAndBackIn(e);
                //}
                //else if (In.InventoryAchievements == id)
                //{
                //    sub.In_InventoryAchievements(e);
                //}
                //else if (In.InventoryAddEffect == id)
                //{
                //    sub.In_InventoryAddEffect(e);
                //}
                //else if (In.InventoryBadges == id)
                //{
                //    sub.In_InventoryBadges(e);
                //}
                //else if (In.InventoryBots == id)
                //{
                //    sub.In_InventoryBots(e);
                //}
                //else if (In.InventoryItemUpdate == id)
                //{
                //    sub.In_InventoryItemUpdate(e);
                //}
                //else if (In.InventoryItems == id)
                //{
                //    sub.In_InventoryItems(e);
                //}
                //else if (In.InventoryPets == id)
                //{
                //    sub.In_InventoryPets(e);
                //}
                //else if (In.InventoryRefresh == id)
                //{
                //    sub.In_InventoryRefresh(e);
                //}
                else if (In.ItemExtraData == id)
                {
                    sub.In_ItemExtraData(e);
                }
                //else if (In.ItemState == id)
                //{
                //    sub.In_ItemState(e);
                //}
                //else if (In.ItemStateComposer2 == id)
                //{
                //    sub.In_ItemStateComposer2(e);
                //}
                //else if (In.ItemsDataUpdate == id)
                //{
                //    sub.In_ItemsDataUpdate(e);
                //}
                //else if (In.JukeBoxMySongs == id)
                //{
                //    sub.In_JukeBoxMySongs(e);
                //}
                //else if (In.JukeBoxNowPlayingMessage == id)
                //{
                //    sub.In_JukeBoxNowPlayingMessage(e);
                //}
                //else if (In.JukeBoxPlayList == id)
                //{
                //    sub.In_JukeBoxPlayList(e);
                //}
                //else if (In.JukeBoxPlayListAddSong == id)
                //{
                //    sub.In_JukeBoxPlayListAddSong(e);
                //}
                //else if (In.JukeBoxPlayListUpdated == id)
                //{
                //    sub.In_JukeBoxPlayListUpdated(e);
                //}
                //else if (In.JukeBoxPlaylistFull == id)
                //{
                //    sub.In_JukeBoxPlaylistFull(e);
                //}
                //else if (In.JukeBoxTrackCode == id)
                //{
                //    sub.In_JukeBoxTrackCode(e);
                //}
                //else if (In.JukeBoxTrackData == id)
                //{
                //    sub.In_JukeBoxTrackData(e);
                //}
                //else if (In.LatencyResponse == id)
                //{
                //    sub.In_LatencyResponse(e);
                //}
                //else if (In.LeprechaunStarterBundle == id)
                //{
                //    sub.In_LeprechaunStarterBundle(e);
                //}
                //else if (In.LoadFriendRequests == id)
                //{
                //    sub.In_LoadFriendRequests(e);
                //}
                //else if (In.LoveLockFurniFinished == id)
                //{
                //    sub.In_LoveLockFurniFinished(e);
                //}
                //else if (In.LoveLockFurniFriendConfirmed == id)
                //{
                //    sub.In_LoveLockFurniFriendConfirmed(e);
                //}
                //else if (In.LoveLockFurniStart == id)
                //{
                //    sub.In_LoveLockFurniStart(e);
                //}
                //else if (In.MachineID == id)
                //{
                //    sub.In_MachineID(e);
                //}
                //else if (In.MarketplaceBuyError == id)
                //{
                //    sub.In_MarketplaceBuyError(e);
                //}
                //else if (In.MarketplaceCancelSale == id)
                //{
                //    sub.In_MarketplaceCancelSale(e);
                //}
                //else if (In.MarketplaceConfig == id)
                //{
                //    sub.In_MarketplaceConfig(e);
                //}
                //else if (In.MarketplaceItemInfo == id)
                //{
                //    sub.In_MarketplaceItemInfo(e);
                //}
                //else if (In.MarketplaceItemPosted == id)
                //{
                //    sub.In_MarketplaceItemPosted(e);
                //}
                //else if (In.MarketplaceOffers == id)
                //{
                //    sub.In_MarketplaceOffers(e);
                //}
                //else if (In.MarketplaceOwnItems == id)
                //{
                //    sub.In_MarketplaceOwnItems(e);
                //}
                //else if (In.MarketplaceSellItem == id)
                //{
                //    sub.In_MarketplaceSellItem(e);
                //}
                //else if (In.MeMenuSettings == id)
                //{
                //    sub.In_MeMenuSettings(e);
                //}
                else if (In.MessagesForYou == id)
                {
                    sub.In_MessagesForYou(e);
                }
                //else if (In.MessengerError == id)
                //{
                //    sub.In_MessengerError(e);
                //}
                //else if (In.MessengerInit == id)
                //{
                //    sub.In_MessengerInit(e);
                //}
                //else if (In.MinimailCount == id)
                //{
                //    sub.In_MinimailCount(e);
                //}
                //else if (In.MinimailNewMessage == id)
                //{
                //    sub.In_MinimailNewMessage(e);
                //}
                //else if (In.ModTool == id)
                //{
                //    sub.In_ModTool(e);
                //}
                //else if (In.ModToolComposerOne == id)
                //{
                //    sub.In_ModToolComposerOne(e);
                //}
                //else if (In.ModToolComposerTwo == id)
                //{
                //    sub.In_ModToolComposerTwo(e);
                //}
                //else if (In.ModToolIssueChatlog == id)
                //{
                //    sub.In_ModToolIssueChatlog(e);
                //}
                //else if (In.ModToolIssueHandled == id)
                //{
                //    sub.In_ModToolIssueHandled(e);
                //}
                //else if (In.ModToolIssueHandlerDimensions == id)
                //{
                //    sub.In_ModToolIssueHandlerDimensions(e);
                //}
                //else if (In.ModToolIssueInfo == id)
                //{
                //    sub.In_ModToolIssueInfo(e);
                //}
                //else if (In.ModToolIssueResponseAlert == id)
                //{
                //    sub.In_ModToolIssueResponseAlert(e);
                //}
                //else if (In.ModToolIssueUpdate == id)
                //{
                //    sub.In_ModToolIssueUpdate(e);
                //}
                //else if (In.ModToolReportReceivedAlert == id)
                //{
                //    sub.In_ModToolReportReceivedAlert(e);
                //}
                //else if (In.ModToolRoomChatlog == id)
                //{
                //    sub.In_ModToolRoomChatlog(e);
                //}
                //else if (In.ModToolRoomInfo == id)
                //{
                //    sub.In_ModToolRoomInfo(e);
                //}
                //else if (In.ModToolSanctionData == id)
                //{
                //    sub.In_ModToolSanctionData(e);
                //}
                //else if (In.ModToolSanctionInfo == id)
                //{
                //    sub.In_ModToolSanctionInfo(e);
                //}
                //else if (In.ModToolUserChatlog == id)
                //{
                //    sub.In_ModToolUserChatlog(e);
                //}
                //else if (In.ModToolUserInfo == id)
                //{
                //    sub.In_ModToolUserInfo(e);
                //}
                //else if (In.ModToolUserRoomVisits == id)
                //{
                //    sub.In_ModToolUserRoomVisits(e);
                //}
                //else if (In.MoodLightData == id)
                //{
                //    sub.In_MoodLightData(e);
                //}
                //else if (In.MutedWhisper == id)
                //{
                //    sub.In_MutedWhisper(e);
                //}
                //else if (In.MysticBoxClose == id)
                //{
                //    sub.In_MysticBoxClose(e);
                //}
                //else if (In.MysticBoxPrize == id)
                //{
                //    sub.In_MysticBoxPrize(e);
                //}
                //else if (In.MysticBoxStartOpen == id)
                //{
                //    sub.In_MysticBoxStartOpen(e);
                //}
                //else if (In.NewNavigatorCategoryUserCount == id)
                //{
                //    sub.In_NewNavigatorCategoryUserCount(e);
                //}
                //else if (In.NewNavigatorCollapsedCategories == id)
                //{
                //    sub.In_NewNavigatorCollapsedCategories(e);
                //}
                //else if (In.NewNavigatorEventCategories == id)
                //{
                //    sub.In_NewNavigatorEventCategories(e);
                //}
                //else if (In.NewNavigatorLiftedRooms == id)
                //{
                //    sub.In_NewNavigatorLiftedRooms(e);
                //}
                //else if (In.NewNavigatorMetaData == id)
                //{
                //    sub.In_NewNavigatorMetaData(e);
                //}
                //else if (In.NewNavigatorRoomEvent == id)
                //{
                //    sub.In_NewNavigatorRoomEvent(e);
                //}
                //else if (In.NewNavigatorSavedSearches == id)
                //{
                //    sub.In_NewNavigatorSavedSearches(e);
                //}
                //else if (In.NewNavigatorSearchResults == id)
                //{
                //    sub.In_NewNavigatorSearchResults(e);
                //}
                //else if (In.NewNavigatorSettings == id)
                //{
                //    sub.In_NewNavigatorSettings(e);
                //}
                //else if (In.NewUserGift == id)
                //{
                //    sub.In_NewUserGift(e);
                //}
                //else if (In.NewUserIdentity == id)
                //{
                //    sub.In_NewUserIdentity(e);
                //}
                //else if (In.NewYearResolution == id)
                //{
                //    sub.In_NewYearResolution(e);
                //}
                //else if (In.NewYearResolutionCompleted == id)
                //{
                //    sub.In_NewYearResolutionCompleted(e);
                //}
                //else if (In.NewYearResolutionProgress == id)
                //{
                //    sub.In_NewYearResolutionProgress(e);
                //}
                //else if (In.NewsWidgets == id)
                //{
                //    sub.In_NewsWidgets(e);
                //}
                //else if (In.NotEnoughPointsType == id)
                //{
                //    sub.In_NotEnoughPointsType(e);
                //}
                //else if (In.NuxAlert == id)
                //{
                //    sub.In_NuxAlert(e);
                //}
                //else if (In.ObjectOnRoller == id)
                //{
                //    sub.In_ObjectOnRoller(e);
                //}
                //else if (In.OldPublicRooms == id)
                //{
                //    sub.In_OldPublicRooms(e);
                //}
                //else if (In.OpenRoomCreationWindow == id)
                //{
                //    sub.In_OpenRoomCreationWindow(e);
                //}
                //else if (In.OtherTradingDisabled == id)
                //{
                //    sub.In_OtherTradingDisabled(e);
                //}
                //else if (In.PetBoughtNotification == id)
                //{
                //    sub.In_PetBoughtNotification(e);
                //}
                //else if (In.PetBreedingCompleted == id)
                //{
                //    sub.In_PetBreedingCompleted(e);
                //}
                //else if (In.PetBreedingFailed == id)
                //{
                //    sub.In_PetBreedingFailed(e);
                //}
                //else if (In.PetBreedingResult == id)
                //{
                //    sub.In_PetBreedingResult(e);
                //}
                //else if (In.PetBreedingStart == id)
                //{
                //    sub.In_PetBreedingStart(e);
                //}
                //else if (In.PetBreedingStartFailed == id)
                //{
                //    sub.In_PetBreedingStartFailed(e);
                //}
                //else if (In.PetBreeds == id)
                //{
                //    sub.In_PetBreeds(e);
                //}
                //else if (In.PetError == id)
                //{
                //    sub.In_PetError(e);
                //}
                //else if (In.PetInfo == id)
                //{
                //    sub.In_PetInfo(e);
                //}
                //else if (In.PetLevelUp == id)
                //{
                //    sub.In_PetLevelUp(e);
                //}
                //else if (In.PetLevelUpdated == id)
                //{
                //    sub.In_PetLevelUpdated(e);
                //}
                //else if (In.PetNameError == id)
                //{
                //    sub.In_PetNameError(e);
                //}
                //else if (In.PetPackageNameValidation == id)
                //{
                //    sub.In_PetPackageNameValidation(e);
                //}
                //else if (In.PetStatusUpdate == id)
                //{
                //    sub.In_PetStatusUpdate(e);
                //}
                //else if (In.PetTrainingPanel == id)
                //{
                //    sub.In_PetTrainingPanel(e);
                //}
                //else if (In.PickMonthlyClubGiftNotification == id)
                //{
                //    sub.In_PickMonthlyClubGiftNotification(e);
                //}
                //else if (In.Ping == id)
                //{
                //    sub.In_Ping(e);
                //}
                //else if (In.PollQuestions == id)
                //{
                //    sub.In_PollQuestions(e);
                //}
                //else if (In.PollStart == id)
                //{
                //    sub.In_PollStart(e);
                //}
                //else if (In.PostItData == id)
                //{
                //    sub.In_PostItData(e);
                //}
                //else if (In.PostItStickyPoleOpen == id)
                //{
                //    sub.In_PostItStickyPoleOpen(e);
                //}
                //else if (In.PresentItemOpened == id)
                //{
                //    sub.In_PresentItemOpened(e);
                //}
                //else if (In.PrivateRooms == id)
                //{
                //    sub.In_PrivateRooms(e);
                //}
                //else if (In.PrivateMessageAlert == id)
                //{
                //    sub.In_PrivateMessageAlert(e);
                //}
                //else if (In.ProfileFriends == id)
                //{
                //    sub.In_ProfileFriends(e);
                //}
                //else if (In.PromoteOwnRoomsList == id)
                //{
                //    sub.In_PromoteOwnRoomsList(e);
                //}
                //else if (In.PublicRooms == id)
                //{
                //    sub.In_PublicRooms(e);
                //}
                else if (In.PurchaseOK == id)
                {
                    sub.In_PurchaseOK(e);
                }
                //else if (In.QuestCompleted == id)
                //{
                //    sub.In_QuestCompleted(e);
                //}
                //else if (In.QuestExpired == id)
                //{
                //    sub.In_QuestExpired(e);
                //}
                //else if (In.ReceiveInvitation == id)
                //{
                //    sub.In_ReceiveInvitation(e);
                //}
                else if (In.ReceivePrivateMessage == id)
                {
                    sub.In_ReceivePrivateMessage(e);
                }
                //else if (In.RecyclerComplete == id)
                //{
                //    sub.In_RecyclerComplete(e);
                //}
                //else if (In.RecyclerLogic == id)
                //{
                //    sub.In_RecyclerLogic(e);
                //}
                //else if (In.RedeemVoucherError == id)
                //{
                //    sub.In_RedeemVoucherError(e);
                //}
                //else if (In.RedeemVoucherOK == id)
                //{
                //    sub.In_RedeemVoucherOK(e);
                //}
                //else if (In.ReloadRecycler == id)
                //{
                //    sub.In_ReloadRecycler(e);
                //}
                //else if (In.RemoveBot == id)
                //{
                //    sub.In_RemoveBot(e);
                //}
                else if (In.RemoveFloorItem == id)
                {
                    sub.In_RemoveFloorItem(e);
                }
                else if (In.RemoveFriend == id)
                {
                    sub.In_RemoveFriend(e); 
                }
                //else if (In.RemoveGuildFromRoom == id)
                //{
                //    sub.In_RemoveGuildFromRoom(e);
                //}
                //else if (In.RemoveHabboItem == id)
                //{
                //    sub.In_RemoveHabboItem(e);
                //}
                //else if (In.RemovePet == id)
                //{
                //    sub.In_RemovePet(e);
                //}
                //else if (In.RemoveRoomEvent == id)
                //{
                //    sub.In_RemoveRoomEvent(e);
                //}
                else if (In.RemoveWallItem == id)
                {
                    sub.In_RemoveWallItem(e);
                }
                //else if (In.RentableItemBuyOutPrice == id)
                //{
                //    sub.In_RentableItemBuyOutPrice(e);
                //}
                //else if (In.RentableSpaceInfo == id)
                //{
                //    sub.In_RentableSpaceInfo(e);
                //}
                //else if (In.ReportRoomForm == id)
                //{
                //    sub.In_ReportRoomForm(e);
                //}
                else if (In.RoomAccessDenied == id)
                {
                    sub.In_RoomAccessDenied(e);
                }
                //else if (In.RoomAdError == id)
                //{
                //    sub.In_RoomAdError(e);
                //}
                //else if (In.RoomAddRightsList == id)
                //{
                //    sub.In_RoomAddRightsList(e);
                //}
                //else if (In.RoomBannedUsers == id)
                //{
                //    sub.In_RoomBannedUsers(e);
                //}
                //else if (In.RoomCategories == id)
                //{
                //    sub.In_RoomCategories(e);
                //}
                //else if (In.RoomCategoryUpdateMessage == id)
                //{
                //    sub.In_RoomCategoryUpdateMessage(e);
                //}
                //else if (In.RoomChatSettings == id)
                //{
                //    sub.In_RoomChatSettings(e);
                //}
                //else if (In.RoomCreated == id)
                //{
                //    sub.In_RoomCreated(e);
                //}
                else if (In.RoomData == id)
                {
                    sub.In_RoomData(e);
                }
                //else if (In.RoomEditSettingsError == id)
                //{
                //    sub.In_RoomEditSettingsError(e);
                //}
                else if (In.RoomEnterError == id)
                {
                    sub.In_RoomEnterError(e);
                }
                //else if (In.RoomEntryInfo == id)
                //{
                //    sub.In_RoomEntryInfo(e);
                //}
                //else if (In.RoomEventMessage == id)
                //{
                //    sub.In_RoomEventMessage(e);
                //}
                //else if (In.RoomFilterWords == id)
                //{
                //    sub.In_RoomFilterWords(e);
                //}
                else if (In.RoomFloorItems == id)
                {
                    sub.In_RoomFloorItems(e);
                }
                //else if (In.RoomFloorThicknessUpdated == id)
                //{
                //    sub.In_RoomFloorThicknessUpdated(e);
                //}
                //else if (In.RoomHeightMap == id)
                //{
                //    sub.In_RoomHeightMap(e);
                //}
                //else if (In.RoomInvite == id)
                //{
                //    sub.In_RoomInvite(e);
                //}
                //else if (In.RoomInviteError == id)
                //{
                //    sub.In_RoomInviteError(e);
                //}
                //else if (In.RoomMessagesPostedCount == id)
                //{
                //    sub.In_RoomMessagesPostedCount(e);
                //}
                //else if (In.RoomModel == id)
                //{
                //    sub.In_RoomModel(e);
                //}
                //else if (In.RoomMuted == id)
                //{
                //    sub.In_RoomMuted(e);
                //}
                //else if (In.RoomNoRights == id)
                //{
                //    sub.In_RoomNoRights(e);
                //}
                else if (In.RoomOpen == id)
                {
                    sub.In_RoomOpen(e);
                }
                //else if (In.RoomOwner == id)
                //{
                //    sub.In_RoomOwner(e);
                //}
                //else if (In.RoomPaint == id)
                //{
                //    sub.In_RoomPaint(e);
                //}
                //else if (In.RoomPetExperience == id)
                //{
                //    sub.In_RoomPetExperience(e);
                //}
                //else if (In.RoomPetHorseFigure == id)
                //{
                //    sub.In_RoomPetHorseFigure(e);
                //}
                //else if (In.RoomPetRespect == id)
                //{
                //    sub.In_RoomPetRespect(e);
                //}
                //else if (In.RoomRelativeMap == id)
                //{
                //    sub.In_RoomRelativeMap(e);
                //}
                //else if (In.RoomRemoveRightsList == id)
                //{
                //    sub.In_RoomRemoveRightsList(e);
                //}
                //else if (In.RoomRights == id)
                //{
                //    sub.In_RoomRights(e);
                //}
                //else if (In.RoomRightsList == id)
                //{
                //    sub.In_RoomRightsList(e);
                //}
                //else if (In.RoomScore == id)
                //{
                //    sub.In_RoomScore(e);
                //}
                //else if (In.RoomSettings == id)
                //{
                //    sub.In_RoomSettings(e);
                //}
                //else if (In.RoomSettingsSaved == id)
                //{
                //    sub.In_RoomSettingsSaved(e);
                //}
                //else if (In.RoomSettingsUpdated == id)
                //{
                //    sub.In_RoomSettingsUpdated(e);
                //}
                //else if (In.RoomThickness == id)
                //{
                //    sub.In_RoomThickness(e);
                //}
                //else if (In.RoomUnitIdle == id)
                //{
                //    sub.In_RoomUnitIdle(e);
                //}
                //else if (In.RoomUserAction == id)
                //{
                //    sub.In_RoomUserAction(e);
                //}
                //else if (In.RoomUserDance == id)
                //{
                //    sub.In_RoomUserDance(e);
                //}
                //else if (In.RoomUserData == id)
                //{
                //    sub.In_RoomUserData(e);
                //}
                //else if (In.RoomUserEffect == id)
                //{
                //    sub.In_RoomUserEffect(e);
                //}
                //else if (In.RoomUserHandItem == id)
                //{
                //    sub.In_RoomUserHandItem(e);
                //}
                //else if (In.RoomUserIgnored == id)
                //{
                //    sub.In_RoomUserIgnored(e);
                //}
                //else if (In.RoomUserNameChanged == id)
                //{
                //    sub.In_RoomUserNameChanged(e);
                //}
                //else if (In.RoomUserReceivedHandItem == id)
                //{
                //    sub.In_RoomUserReceivedHandItem(e);
                //}
                else if (In.RoomUserRemove == id)
                {
                    sub.In_RoomUserRemove(e);
                }
                //else if (In.RoomUserRemoveRights == id)
                //{
                //    sub.In_RoomUserRemoveRights(e);
                //}
                //else if (In.RoomUserRespect == id)
                //{
                //    sub.In_RoomUserRespect(e);
                //}
                else if (In.RoomUserShout == id)
                {
                    sub.In_RoomUserShout(e);
                }
                //else if (In.RoomUserStatus == id)
                //{
                //    sub.In_RoomUserStatus(e);
                //}
                //else if (In.RoomUserTags == id)
                //{
                //    sub.In_RoomUserTags(e);
                //}
                else if (In.RoomUserTalk == id)
                {
                    sub.In_RoomUserTalk(e);
                }
                //else if (In.RoomUserTyping == id)
                //{
                //    sub.In_RoomUserTyping(e);
                //}
                //else if (In.RoomUserUnbanned == id)
                //{
                //    sub.In_RoomUserUnbanned(e);
                //}
                else if (In.RoomUserWhisper == id)
                {
                    sub.In_RoomUserWhisper(e);
                }
                else if (In.RoomUsers == id)
                {
                    sub.In_RoomUsers(e);
                }
                //else if (In.RoomUsersGuildBadges == id)
                //{
                //    sub.In_RoomUsersGuildBadges(e);
                //}
                else if (In.RoomWallItems == id)
                {
                    sub.In_RoomWallItems(e);
                }
                //else if (In.SecureLoginOK == id)
                //{
                //    sub.In_SecureLoginOK(e);
                //}
                //else if (In.SessionRights == id)
                //{
                //    sub.In_SessionRights(e);
                //}
                //else if (In.SimplePollAnswer == id)
                //{
                //    sub.In_SimplePollAnswer(e);
                //}
                //else if (In.SimplePollAnswers == id)
                //{
                //    sub.In_SimplePollAnswers(e);
                //}
                //else if (In.SimplePollStart == id)
                //{
                //    sub.In_SimplePollStart(e);
                //}
                //else if (In.StaffAlertAndOpenHabboWay == id)
                //{
                //    sub.In_StaffAlertAndOpenHabboWay(e);
                //}
                //else if (In.StaffAlertWIthLinkAndOpenHabboWay == id)
                //{
                //    sub.In_StaffAlertWIthLinkAndOpenHabboWay(e);
                //}
                //else if (In.StaffAlertWithLink == id)
                //{
                //    sub.In_StaffAlertWithLink(e);
                //}
                //else if (In.StalkError == id)
                //{
                //    sub.In_StalkError(e);
                //}
                //else if (In.SubmitCompetitionRoom == id)
                //{
                //    sub.In_SubmitCompetitionRoom(e);
                //}
                //else if (In.Tags == id)
                //{
                //    sub.In_Tags(e);
                //}
                //else if (In.TalentLevelUpdate == id)
                //{
                //    sub.In_TalentLevelUpdate(e);
                //}
                //else if (In.TalentTrack == id)
                //{
                //    sub.In_TalentTrack(e);
                //}
                //else if (In.TalentTrackEmailFailed == id)
                //{
                //    sub.In_TalentTrackEmailFailed(e);
                //}
                //else if (In.TalentTrackEmailVerified == id)
                //{
                //    sub.In_TalentTrackEmailVerified(e);
                //}
                //else if (In.TargetedOffer == id)
                //{
                //    sub.In_TargetedOffer(e);
                //}
                //else if (In.TradeAccepted == id)
                //{
                //    sub.In_TradeAccepted(e);
                //}
                //else if (In.TradeCloseWindow == id)
                //{
                //    sub.In_TradeCloseWindow(e);
                //}
                //else if (In.TradeComplete == id)
                //{
                //    sub.In_TradeComplete(e);
                //}
                //else if (In.TradeStart == id)
                //{
                //    sub.In_TradeStart(e);
                //}
                //else if (In.TradeStartFail == id)
                //{
                //    sub.In_TradeStartFail(e);
                //}
                else if (In.TradeStopped == id)
                {
                    sub.In_TradeStopped(e);
                }
                //else if (In.TradeUpdate == id)
                //{
                //    sub.In_TradeUpdate(e);
                //}
                //else if (In.TradingWaitingConfirm == id)
                //{
                //    sub.In_TradingWaitingConfirm(e);
                //}
                //else if (In.UpdateFailed == id)
                //{
                //    sub.In_UpdateFailed(e);
                //}
                //else if (In.UpdateFriend == id)
                //{
                //    sub.In_UpdateFriend(e);
                //}
                //else if (In.UpdateStackHeight == id)
                //{
                //    sub.In_UpdateStackHeight(e);
                //}
                //else if (In.UpdateStackHeightTileHeight == id)
                //{
                //    sub.In_UpdateStackHeightTileHeight(e);
                //}
                //else if (In.UpdateUserLook == id)
                //{
                //    sub.In_UpdateUserLook(e);
                //}
                //else if (In.UserAchievementScore == id)
                //{
                //    sub.In_UserAchievementScore(e);
                //}
                //else if (In.UserBadges == id)
                //{
                //    sub.In_UserBadges(e);
                //}
                //else if (In.UserCitizinShip == id)
                //{
                //    sub.In_UserCitizinShip(e);
                //}
                //else if (In.UserClothes == id)
                //{
                //    sub.In_UserClothes(e);
                //}
                //else if (In.UserClub == id)
                //{
                //    sub.In_UserClub(e);
                //}
                //else if (In.UserCredits == id)
                //{
                //    sub.In_UserCredits(e);
                //}
                //else if (In.UserCurrency == id)
                //{
                //    sub.In_UserCurrency(e);
                //}
                //else if (In.UserData == id)
                //{
                //    sub.In_UserData(e);
                //}
                //else if (In.UserEffectsList == id)
                //{
                //    sub.In_UserEffectsList(e);
                //}
                //else if (In.UserHomeRoom == id)
                //{
                //    sub.In_UserHomeRoom(e);
                //}
                //else if (In.UserPerks == id)
                //{
                //    sub.In_UserPerks(e);
                //}
                else if (In.UserPermissions == id)
                {
                    sub.In_UserPermissions(e);
                }
                //else if (In.UserPoints == id)
                //{
                //    sub.In_UserPoints(e);
                //}
                else if (In.UserProfile == id)
                {
                    sub.In_UserProfile(e);
                }
                //else if (In.UserSearchResult == id)
                //{
                //    sub.In_UserSearchResult(e);
                //}
                //else if (In.UserWardrobe == id)
                //{
                //    sub.In_UserWardrobe(e);
                //}
                //else if (In.VerifyMobileNumber == id)
                //{
                //    sub.In_VerifyMobileNumber(e);
                //}
                //else if (In.VerifyMobilePhoneCodeWindow == id)
                //{
                //    sub.In_VerifyMobilePhoneCodeWindow(e);
                //}
                //else if (In.VerifyMobilePhoneDone == id)
                //{
                //    sub.In_VerifyMobilePhoneDone(e);
                //}
                //else if (In.VerifyMobilePhoneWindow == id)
                //{
                //    sub.In_VerifyMobilePhoneWindow(e);
                //}
                //else if (In.VerifyPrimes == id)
                //{
                //    sub.In_VerifyPrimes(e);
                //}
                //else if (In.VipTutorialsStart == id)
                //{
                //    sub.In_VipTutorialsStart(e);
                //}
                else if (In.WallItemUpdate == id)
                {
                    sub.In_WallItemUpdate(e);
                }
                //else if (In.WatchAndEarnReward == id)
                //{
                //    sub.In_WatchAndEarnReward(e);
                //}
                //else if (In.WelcomeGift == id)
                //{
                //    sub.In_WelcomeGift(e);
                //}
                //else if (In.WelcomeGiftError == id)
                //{
                //    sub.In_WelcomeGiftError(e);
                //}
                //else if (In.WiredConditionData == id)
                //{
                //    sub.In_WiredConditionData(e);
                //}
                //else if (In.WiredEffectData == id)
                //{
                //    sub.In_WiredEffectData(e);
                //}
                //else if (In.WiredRewardAlert == id)
                //{
                //    sub.In_WiredRewardAlert(e);
                //}
                //else if (In.WiredSaved == id)
                //{
                //    sub.In_WiredSaved(e);
                //}
                //else if (In.WiredTriggerData == id)
                //{
                //    sub.In_WiredTriggerData(e);
                //}
                //else if (In.YouTradingDisabled == id)
                //{
                //    sub.In_YouTradingDisabled(e);
                //}
                //else if (In.YoutubeDisplayList == id)
                //{
                //    sub.In_YoutubeDisplayList(e);
                //}
                //else if (In.YoutubeMessageComposer2 == id)
                //{
                //    sub.In_YoutubeMessageComposer2(e);
                //}
                //else if (In.YoutubeMessageComposer3 == id)
                //{
                //    sub.In_YoutubeMessageComposer3(e);
                //}
            }
        }
    }
}