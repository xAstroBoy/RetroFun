using RetroFun.Controls;
using RetroFun.Pages;
using RetroFun.Subscribers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Geode.Extension;
using Geode.Network;

namespace RetroFun
{
    [DesignerCategory("Form")]

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

        // REMEMBER TO ADD EACH NEW PAGE IN THIS LIST, OR ELSE THE PAGE WILL BE UNABLE TO INTERCEPT  FROM THE VIRTUAL VOIDS!
        // TODO: MAKE IT AUTOMATIC!
        public MainFrm()
        {
            // Must be set before initializing components.
            Program.Master = this;
            InitializeComponent();

            Program.Master.OnDataInterceptEvent += HandlePackets;

            //Pages sharing events
            _subscribers = new List<ObservablePage>
            {
               BottomPg,
               furniHandlerEvent,
                FurnitureCheckerPg,
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
                FurniTrollPg,
                UtilitiesPg,
                PetPg,
                UserEditorPg,
                PersonalPg,
                ModerationPg,
                FunPg,

             };

            Bind(AlwaysOnTopChbx, "Checked", nameof(IsAlwaysOnTop));
            Extension.Start();
        }

        // WHEN ADDING A PACKET, FIND IF THE HandleOutGoing and HandleIncoming In or Out headers are decommented
        // this way it should register and work with the virtual voids!
        // The virtual voids are set for all known packets registered in sulakore

        private void HandlePackets(DataInterceptedEventArgs e)
        {

            foreach (var sub in _subscribers)
            {
                e.Packet.Position = 0;

                #region OutGoing
                if (Extension.Out.AdvertisingSave.Match(e)) { sub.Out_AdvertisingSave(e); }
                //else if (Extension.Out.AcceptFriendRequest.Match(e)){sub.Out_AcceptFriendRequest(e);}
                //else if (Extension.Out.ActivateEffect.Match(e)){sub.Out_ActivateEffect(e);}
                //else if (Extension.Out.AdventCalendarForceOpen.Match(e)){sub.Out_AdventCalendarForceOpen(e);}
                //else if (Extension.Out.AdventCalendarOpenDay.Match(e)){sub.Out_AdventCalendarOpenDay(e);}
                //else if (Extension.Out.AmbassadorAlertCommand.Match(e)){sub.Out_AmbassadorAlertCommand(e);}
                //else if (Extension.Out.AmbassadorVisitCommand.Match(e)){sub.Out_AmbassadorVisitCommand(e);}
                //else if (Extension.Out.AnswerPoll.Match(e)){sub.Out_AnswerPoll(e);}
                //else if (Extension.Out.BotPickup.Match(e)){sub.Out_BotPickup(e);}
                //else if (Extension.Out.BotPlace.Match(e)){sub.Out_BotPlace(e);}
                //else if (Extension.Out.BotSaveSettings.Match(e)){sub.Out_BotSaveSettings(e);}
                //else if (Extension.Out.BotSettings.Match(e)){sub.Out_BotSettings(e);}
                //else if (Extension.Out.BreedPets.Match(e)){sub.Out_BreedPets(e);}
                //else if (Extension.Out.BuyItem.Match(e)){sub.Out_BuyItem(e);}
                //else if (Extension.Out.BuyRoomPromotion.Match(e)){sub.Out_BuyRoomPromotion(e);}
                //else if (Extension.Out.CameraPublishToWeb.Match(e)){sub.Out_CameraPublishToWeb(e);}
                //else if (Extension.Out.CameraPurchase.Match(e)){sub.Out_CameraPurchase(e);}
                //else if (Extension.Out.CameraRoomPicture.Match(e)){sub.Out_CameraRoomPicture(e);}
                //else if (Extension.Out.CameraRoomThumbnail.Match(e)){sub.Out_CameraRoomThumbnail(e);}
                //else if (Extension.Out.CancelPoll.Match(e)){sub.Out_CancelPoll(e);}
                else if (Extension.Out.CatalogBuyItem.Match(e)) { sub.Out_CatalogBuyItem(e); }
                //else if (Extension.Out.CatalogBuyItemAsGift.Match(e)){sub.Out_CatalogBuyItemAsGift(e);}
                //else if (Extension.Out.CatalogSearchedItem.Match(e)){sub.Out_CatalogSearchedItem(e);}
                //else if (Extension.Out.ChangeNameCheckUsername.Match(e)){sub.Out_ChangeNameCheckUsername(e);}
                //else if (Extension.Out.ChangeRelation.Match(e)){sub.Out_ChangeRelation(e);}
                //else if (Extension.Out.CheckPetName.Match(e)){sub.Out_CheckPetName(e);}
                //else if (Extension.Out.ClientVariables.Match(e)){sub.Out_ClientVariables(e);}
                else if (Extension.Out.CloseDice.Match(e)) { sub.Out_CloseDice(e); }
                //else if (Extension.Out.CompostMonsterplant.Match(e)){sub.Out_CompostMonsterplant(e);}
                //else if (Extension.Out.ConfirmChangeName.Match(e)){sub.Out_ConfirmChangeName(e);}
                //else if (Extension.Out.CraftingAddRecipe.Match(e)){sub.Out_CraftingAddRecipe(e);}
                //else if (Extension.Out.CraftingCraftItem.Match(e)){sub.Out_CraftingCraftItem(e);}
                //else if (Extension.Out.CraftingCraftSecret.Match(e)){sub.Out_CraftingCraftSecret(e);}
                //else if (Extension.Out.DeclineFriendRequest.Match(e)){sub.Out_DeclineFriendRequest(e);}
                //else if (Extension.Out.EditRoomPromotionMessage.Match(e)){sub.Out_EditRoomPromotionMessage(e);}
                //else if (Extension.Out.EnableEffect.Match(e)){sub.Out_EnableEffect(e);}
                //else if (Extension.Out.FindNewFriends.Match(e)){sub.Out_FindNewFriends(e);}
                //else if (Extension.Out.FloorPlanEditorRequestBlockedTiles.Match(e)){sub.Out_FloorPlanEditorRequestBlockedTiles(e);}
                //else if (Extension.Out.FloorPlanEditorRequestDoorSettings.Match(e)){sub.Out_FloorPlanEditorRequestDoorSettings(e);}
                //else if (Extension.Out.FloorPlanEditorSave.Match(e)){sub.Out_FloorPlanEditorSave(e);}
                //else if (Extension.Out.FootballGateSaveLook.Match(e)){sub.Out_FootballGateSaveLook(e);}
                //else if (Extension.Out.FriendPrivateMessage.Match(e)){sub.Out_FriendPrivateMessage(e);}
                //else if (Extension.Out.FriendRequest.Match(e)){sub.Out_FriendRequest(e);}
                //else if (Extension.Out.GameCenter.Match(e)){sub.Out_GameCenter(e);}
                //else if (Extension.Out.GameCenterJoinGame.Match(e)){sub.Out_GameCenterJoinGame(e);}
                //else if (Extension.Out.GameCenterLoadGame.Match(e)){sub.Out_GameCenterLoadGame(e);}
                //else if (Extension.Out.GameCenterRequestAccountStatus.Match(e)){sub.Out_GameCenterRequestAccountStatus(e);}
                //else if (Extension.Out.GameCenterRequestGameStatus.Match(e)){sub.Out_GameCenterRequestGameStatus(e);}
                //else if (Extension.Out.GenerateSecretKey.Match(e)){sub.Out_GenerateSecretKey(e);}
                //else if (Extension.Out.GetClubData.Match(e)){sub.Out_GetClubData(e);}
                //else if (Extension.Out.GetHabboGuildBadgesMessage.Match(e)){sub.Out_GetHabboGuildBadgesMessage(e);}
                //else if (Extension.Out.GetMarketplaceConfig.Match(e)){sub.Out_GetMarketplaceConfig(e);}
                //else if (Extension.Out.GetPollData.Match(e)){sub.Out_GetPollData(e);}
                //else if (Extension.Out.GuardianAcceptRequest.Match(e)){sub.Out_GuardianAcceptRequest(e);}
                //else if (Extension.Out.GuardianNoUpdatesWanted.Match(e)){sub.Out_GuardianNoUpdatesWanted(e);}
                //else if (Extension.Out.GuardianVote.Match(e)){sub.Out_GuardianVote(e);}
                //else if (Extension.Out.GuideCancelHelpRequest.Match(e)){sub.Out_GuideCancelHelpRequest(e);}
                //else if (Extension.Out.GuideCloseHelpRequest.Match(e)){sub.Out_GuideCloseHelpRequest(e);}
                //else if (Extension.Out.GuideHandleHelpRequest.Match(e)){sub.Out_GuideHandleHelpRequest(e);}

                //else if (Extension.Out.GuideInviteUser.Match(e)){sub.Out_GuideInviteUser(e);}
                //else if (Extension.Out.GuideRecommendHelper.Match(e)){sub.Out_GuideRecommendHelper(e);}
                //else if (Extension.Out.GuideReportHelper.Match(e)){sub.Out_GuideReportHelper(e);}
                //else if (Extension.Out.GuideUserMessage.Match(e)){sub.Out_GuideUserMessage(e);}
                //else if (Extension.Out.GuideUserTyping.Match(e)){sub.Out_GuideUserTyping(e);}
                //else if (Extension.Out.GuideVisitUser.Match(e)){sub.Out_GuideVisitUser(e);}
                //else if (Extension.Out.GuildAcceptMembership.Match(e)){sub.Out_GuildAcceptMembership(e);}
                //else if (Extension.Out.GuildChangeBadge.Match(e)){sub.Out_GuildChangeBadge(e);}
                //else if (Extension.Out.GuildChangeColors.Match(e)){sub.Out_GuildChangeColors(e);}
                //else if (Extension.Out.GuildChangeNameDesc.Match(e)){sub.Out_GuildChangeNameDesc(e);}
                //else if (Extension.Out.GuildChangeSettings.Match(e)){sub.Out_GuildChangeSettings(e);}
                //else if (Extension.Out.GuildConfirmRemoveMember.Match(e)){sub.Out_GuildConfirmRemoveMember(e);}
                //else if (Extension.Out.GuildDeclineMembership.Match(e)){sub.Out_GuildDeclineMembership(e);}
                //else if (Extension.Out.GuildDelete.Match(e)){sub.Out_GuildDelete(e);}
                //else if (Extension.Out.GuildRemoveAdmin.Match(e)){sub.Out_GuildRemoveAdmin(e);}
                //else if (Extension.Out.GuildRemoveFavorite.Match(e)){sub.Out_GuildRemoveFavorite(e);}
                //else if (Extension.Out.GuildRemoveMember.Match(e)){sub.Out_GuildRemoveMember(e);}
                //else if (Extension.Out.GuildSetAdmin.Match(e)){sub.Out_GuildSetAdmin(e);}
                //else if (Extension.Out.GuildSetFavorite.Match(e)){sub.Out_GuildSetFavorite(e);}
                //else if (Extension.Out.HandleDoorbell.Match(e)){sub.Out_HandleDoorbell(e);}
                //else if (Extension.Out.HorseRide.Match(e)){sub.Out_HorseRide(e);}
                //else if (Extension.Out.HorseRideSettings.Match(e)){sub.Out_HorseRideSettings(e);}
                //else if (Extension.Out.HorseUseItem.Match(e)){sub.Out_HorseUseItem(e);}
                //else if (Extension.Out.HotelView.Match(e)){sub.Out_HotelView(e);}
                //else if (Extension.Out.HotelViewClaimBadge.Match(e)){sub.Out_HotelViewClaimBadge(e);}
                //else if (Extension.Out.HotelViewClaimBadgeReward.Match(e)){sub.Out_HotelViewClaimBadgeReward(e);}
                //else if (Extension.Out.HotelViewConcurrentUsersButton.Match(e)){sub.Out_HotelViewConcurrentUsersButton(e);}
                //else if (Extension.Out.HotelViewData.Match(e)){sub.Out_HotelViewData(e);}
                //else if (Extension.Out.HotelViewRequestBadgeReward.Match(e)){sub.Out_HotelViewRequestBadgeReward(e);}
                //else if (Extension.Out.HotelViewRequestBonusRare.Match(e)){sub.Out_HotelViewRequestBonusRare(e);}
                //else if (Extension.Out.HotelViewRequestCommunityGoal.Match(e)){sub.Out_HotelViewRequestCommunityGoal(e);}
                //else if (Extension.Out.HotelViewRequestConcurrentUsers.Match(e)){sub.Out_HotelViewRequestConcurrentUsers(e);}
                //else if (Extension.Out.IgnoreRoomUser.Match(e)){sub.Out_IgnoreRoomUser(e);}
                //else if (Extension.Out.InitCrypto.Match(e)){sub.Out_InitCrypto(e);}
                //else if (Extension.Out.InviteFriends.Match(e)){sub.Out_InviteFriends(e);}
                //else if (Extension.Out.JukeBoxAddSoundTrack.Match(e)){sub.Out_JukeBoxAddSoundTrack(e);}
                //else if (Extension.Out.JukeBoxEventOne.Match(e)){sub.Out_JukeBoxEventOne(e);}
                //else if (Extension.Out.JukeBoxEventThree.Match(e)){sub.Out_JukeBoxEventThree(e);}
                //else if (Extension.Out.JukeBoxEventTwo.Match(e)){sub.Out_JukeBoxEventTwo(e);}
                //else if (Extension.Out.JukeBoxRequestPlayList.Match(e)){sub.Out_JukeBoxRequestPlayList(e);}
                //else if (Extension.Out.JukeBoxRequestTrackCode.Match(e)){sub.Out_JukeBoxRequestTrackCode(e);}
                //else if (Extension.Out.JukeBoxRequestTrackData.Match(e)){sub.Out_JukeBoxRequestTrackData(e);}
                else if (Extension.Out.LatencyTest.Match(e)) { sub.Out_LatencyTest(e); }
                //else if (Extension.Out.MachineID.Match(e)){sub.Out_MachineID(e);}
                //else if (Extension.Out.MannequinSaveLook.Match(e)){sub.Out_MannequinSaveLook(e);}
                //else if (Extension.Out.MannequinSaveName.Match(e)){sub.Out_MannequinSaveName(e);}
                //else if (Extension.Out.ModToolAlert.Match(e)){sub.Out_ModToolAlert(e);}
                //else if (Extension.Out.ModToolBan.Match(e)){sub.Out_ModToolBan(e);}
                //else if (Extension.Out.ModToolChangeRoomSettings.Match(e)){sub.Out_ModToolChangeRoomSettings(e);}
                //else if (Extension.Out.ModToolCloseTicket.Match(e)){sub.Out_ModToolCloseTicket(e);}
                //else if (Extension.Out.ModToolKick.Match(e)){sub.Out_ModToolKick(e);}
                //else if (Extension.Out.ModToolPickTicket.Match(e)){sub.Out_ModToolPickTicket(e);}
                //else if (Extension.Out.ModToolReleaseTicket.Match(e)){sub.Out_ModToolReleaseTicket(e);}
                //else if (Extension.Out.ModToolRequestIssueChatlog.Match(e)){sub.Out_ModToolRequestIssueChatlog(e);}
                //else if (Extension.Out.ModToolRequestRoomChatlog.Match(e)){sub.Out_ModToolRequestRoomChatlog(e);}
                //else if (Extension.Out.ModToolRequestRoomInfo.Match(e)){sub.Out_ModToolRequestRoomInfo(e);}
                //else if (Extension.Out.ModToolRequestRoomUserChatlog.Match(e)){sub.Out_ModToolRequestRoomUserChatlog(e);}
                //else if (Extension.Out.ModToolRequestRoomVisits.Match(e)){sub.Out_ModToolRequestRoomVisits(e);}
                //else if (Extension.Out.ModToolRequestUserChatlog.Match(e)){sub.Out_ModToolRequestUserChatlog(e);}
                //else if (Extension.Out.ModToolRequestUserInfo.Match(e)){sub.Out_ModToolRequestUserInfo(e);}
                //else if (Extension.Out.ModToolRoomAlert.Match(e)){sub.Out_ModToolRoomAlert(e);}
                //else if (Extension.Out.ModToolSanctionAlert.Match(e)){sub.Out_ModToolSanctionAlert(e);}
                //else if (Extension.Out.ModToolSanctionBan.Match(e)){sub.Out_ModToolSanctionBan(e);}
                //else if (Extension.Out.ModToolSanctionMute.Match(e)){sub.Out_ModToolSanctionMute(e);}
                //else if (Extension.Out.ModToolSanctionTradeLock.Match(e)){sub.Out_ModToolSanctionTradeLock(e);}
                //else if (Extension.Out.ModToolWarn.Match(e)){sub.Out_ModToolWarn(e);}
                //else if (Extension.Out.MoodLightSaveSettings.Match(e)){sub.Out_MoodLightSaveSettings(e);}
                //else if (Extension.Out.MoodLightSettings.Match(e)){sub.Out_MoodLightSettings(e);}
                //else if (Extension.Out.MoodLightTurnOn.Match(e)){sub.Out_MoodLightTurnOn(e);}
                //else if (Extension.Out.MovePet.Match(e)){sub.Out_MovePet(e);}
                else if (Extension.Out.MoveWallItem.Match(e)) { sub.Out_MoveWallItem(e); }
                //else if (Extension.Out.NavigatorCategoryListMode.Match(e)){sub.Out_NavigatorCategoryListMode(e);}
                //else if (Extension.Out.NavigatorCollapseCategory.Match(e)){sub.Out_NavigatorCollapseCategory(e);}
                //else if (Extension.Out.NavigatorUncollapseCategory.Match(e)){sub.Out_NavigatorUncollapseCategory(e);}
                //else if (Extension.Out.NewNavigatorAction.Match(e)){sub.Out_NewNavigatorAction(e);}
                //else if (Extension.Out.OpenRecycleBox.Match(e)){sub.Out_OpenRecycleBox(e);}
                //else if (Extension.Out.PetPackageName.Match(e)){sub.Out_PetPackageName(e);}
                //else if (Extension.Out.PetPickup.Match(e)){sub.Out_PetPickup(e);}
                //else if (Extension.Out.PetPlace.Match(e)){sub.Out_PetPlace(e);}
                //else if (Extension.Out.PickNewUserGift.Match(e)){sub.Out_PickNewUserGift(e);}
                //else if (Extension.Out.Pong.Match(e)){sub.Out_Pong(e);}
                //else if (Extension.Out.PostItDelete.Match(e)){sub.Out_PostItDelete(e);}
                //else if (Extension.Out.PostItPlace.Match(e)){sub.Out_PostItPlace(e);}
                //else if (Extension.Out.PostItRequestData.Match(e)){sub.Out_PostItRequestData(e);}
                //else if (Extension.Out.PostItSaveData.Match(e)){sub.Out_PostItSaveData(e);}
                //else if (Extension.Out.Recycle.Match(e)){sub.Out_Recycle(e);}
                //else if (Extension.Out.RedeemClothing.Match(e)){sub.Out_RedeemClothing(e);}
                //else if (Extension.Out.RedeemItem.Match(e)){sub.Out_RedeemItem(e);}
                //else if (Extension.Out.RedeemVoucher.Match(e)){sub.Out_RedeemVoucher(e);}
                //else if (Extension.Out.ReleaseVersion.Match(e)){sub.Out_ReleaseVersion(e);}
                //else if (Extension.Out.ReloadRecycler.Match(e)){sub.Out_ReloadRecycler(e);}
                else if (Extension.Out.RemoveFriend.Match(e)) { sub.Out_RemoveFriend(e); }
                //else if (Extension.Out.RentSpace.Match(e)){sub.Out_RentSpace(e);}
                //else if (Extension.Out.RentSpaceCancel.Match(e)){sub.Out_RentSpaceCancel(e);}
                //else if (Extension.Out.Report.Match(e)){sub.Out_Report(e);}
                //else if (Extension.Out.ReportBully.Match(e)){sub.Out_ReportBully(e);}
                //else if (Extension.Out.RequestAchievementConfiguration.Match(e)){sub.Out_RequestAchievementConfiguration(e);}
                //else if (Extension.Out.RequestAchievements.Match(e)){sub.Out_RequestAchievements(e);}
                //else if (Extension.Out.RequestCameraConfiguration.Match(e)){sub.Out_RequestCameraConfiguration(e);}
                //else if (Extension.Out.RequestCanCreateRoom.Match(e)){sub.Out_RequestCanCreateRoom(e);}
                //else if (Extension.Out.RequestCatalogIndex.Match(e)){sub.Out_RequestCatalogIndex(e);}
                //else if (Extension.Out.RequestCatalogMode.Match(e)){sub.Out_RequestCatalogMode(e);}
                //else if (Extension.Out.RequestCatalogPage.Match(e)){sub.Out_RequestCatalogPage(e);}
                //else if (Extension.Out.RequestClubGifts.Match(e)){sub.Out_RequestClubGifts(e);}
                //else if (Extension.Out.RequestCraftingRecipes.Match(e)){sub.Out_RequestCraftingRecipes(e);}
                //else if (Extension.Out.RequestCraftingRecipesAvailable.Match(e)){sub.Out_RequestCraftingRecipesAvailable(e);}
                //else if (Extension.Out.RequestCreateRoom.Match(e)){sub.Out_RequestCreateRoom(e);}
                //else if (Extension.Out.RequestCredits.Match(e)){sub.Out_RequestCredits(e);}
                //else if (Extension.Out.RequestDeleteRoom.Match(e)){sub.Out_RequestDeleteRoom(e);}
                //else if (Extension.Out.RequestDiscount.Match(e)){sub.Out_RequestDiscount(e);}
                //else if (Extension.Out.RequestFriendRequest.Match(e)){sub.Out_RequestFriendRequest(e);}
                //else if (Extension.Out.RequestFriends.Match(e)){sub.Out_RequestFriends(e);}
                //else if (Extension.Out.RequestGameConfigurations.Match(e)){sub.Out_RequestGameConfigurations(e);}
                //else if (Extension.Out.RequestGiftConfiguration.Match(e)){sub.Out_RequestGiftConfiguration(e);}
                //else if (Extension.Out.RequestGuideAssistance.Match(e)){sub.Out_RequestGuideAssistance(e);}
                //else if (Extension.Out.RequestGuideTool.Match(e)){sub.Out_RequestGuideTool(e);}
                //else if (Extension.Out.RequestGuildBuy.Match(e)){sub.Out_RequestGuildBuy(e);}
                //else if (Extension.Out.RequestGuildBuyRooms.Match(e)){sub.Out_RequestGuildBuyRooms(e);}
                //else if (Extension.Out.RequestGuildFurniWidget.Match(e)){sub.Out_RequestGuildFurniWidget(e);}
                //else if (Extension.Out.RequestGuildInfo.Match(e)){sub.Out_RequestGuildInfo(e);}
                //else if (Extension.Out.RequestGuildJoin.Match(e)){sub.Out_RequestGuildJoin(e);}
                //else if (Extension.Out.RequestGuildManage.Match(e)){sub.Out_RequestGuildManage(e);}
                //else if (Extension.Out.RequestGuildMembers.Match(e)){sub.Out_RequestGuildMembers(e);}
                //else if (Extension.Out.RequestGuildParts.Match(e)){sub.Out_RequestGuildParts(e);}
                //else if (Extension.Out.RequestHeightmap.Match(e)){sub.Out_RequestHeightmap(e);}
                //else if (Extension.Out.RequestHighestScoreRooms.Match(e)){sub.Out_RequestHighestScoreRooms(e);}
                //else if (Extension.Out.RequestInitFriends.Match(e)){sub.Out_RequestInitFriends(e);}
                //else if (Extension.Out.RequestInventoryBadges.Match(e)){sub.Out_RequestInventoryBadges(e);}
                //else if (Extension.Out.RequestInventoryBots.Match(e)){sub.Out_RequestInventoryBots(e);}
                //else if (Extension.Out.RequestInventoryItems.Match(e)){sub.Out_RequestInventoryItems(e);}
                //else if (Extension.Out.RequestInventoryPets.Match(e)){sub.Out_RequestInventoryPets(e);}
                //else if (Extension.Out.RequestItemInfo.Match(e)){sub.Out_RequestItemInfo(e);}
                //else if (Extension.Out.RequestMeMenuSettings.Match(e)){sub.Out_RequestMeMenuSettings(e);}
                //else if (Extension.Out.RequestMyRooms.Match(e)){sub.Out_RequestMyRooms(e);}
                //else if (Extension.Out.RequestNavigatorSettings.Match(e)){sub.Out_RequestNavigatorSettings(e);}
                //else if (Extension.Out.RequestNewNavigatorData.Match(e)){sub.Out_RequestNewNavigatorData(e);}
                //else if (Extension.Out.RequestNewNavigatorRooms.Match(e)){sub.Out_RequestNewNavigatorRooms(e);}
                //else if (Extension.Out.RequestNewsList.Match(e)){sub.Out_RequestNewsList(e);}
                //else if (Extension.Out.RequestOffers.Match(e)){sub.Out_RequestOffers(e);}
                //else if (Extension.Out.RequestOwnGuilds.Match(e)){sub.Out_RequestOwnGuilds(e);}
                //else if (Extension.Out.RequestOwnItems.Match(e)){sub.Out_RequestOwnItems(e);}
                //else if (Extension.Out.RequestPetBreeds.Match(e)){sub.Out_RequestPetBreeds(e);}
                else if (Extension.Out.RequestPetInfo.Match(e)) { sub.Out_RequestPetInfo(e); }
                //else if (Extension.Out.RequestPetTrainingPanel.Match(e)){sub.Out_RequestPetTrainingPanel(e);}
                //else if (Extension.Out.RequestPopularRooms.Match(e)){sub.Out_RequestPopularRooms(e);}
                //else if (Extension.Out.RequestProfileFriends.Match(e)){sub.Out_RequestProfileFriends(e);}
                //else if (Extension.Out.RequestPromotedRooms.Match(e)){sub.Out_RequestPromotedRooms(e);}
                //else if (Extension.Out.RequestPromotionRooms.Match(e)){sub.Out_RequestPromotionRooms(e);}
                //else if (Extension.Out.RequestPublicRooms.Match(e)){sub.Out_RequestPublicRooms(e);}
                //else if (Extension.Out.RequestRecylerLogic.Match(e)){sub.Out_RequestRecylerLogic(e);}
                //else if (Extension.Out.RequestReportRoom.Match(e)){sub.Out_RequestReportRoom(e);}
                //else if (Extension.Out.RequestReportUserBullying.Match(e)){sub.Out_RequestReportUserBullying(e);}
                //else if (Extension.Out.RequestResolution.Match(e)){sub.Out_RequestResolution(e);}
                //else if (Extension.Out.RequestRoomCategories.Match(e)){sub.Out_RequestRoomCategories(e);}
                else if (Extension.Out.RequestRoomData.Match(e)) { sub.Out_RequestRoomData(e); }
                else if (Extension.Out.RequestRoomHeightmap.Match(e)) { sub.Out_RequestRoomHeightmap(e); }
                else if (Extension.Out.RequestRoomLoad.Match(e)) { sub.Out_RequestRoomLoad(e); }
                //else if (Extension.Out.RequestRoomRights.Match(e)){sub.Out_RequestRoomRights(e);}
                //else if (Extension.Out.RequestRoomSettings.Match(e)){sub.Out_RequestRoomSettings(e);}
                //else if (Extension.Out.RequestRoomWordFilter.Match(e)){sub.Out_RequestRoomWordFilter(e);}
                //else if (Extension.Out.RequestSellItem.Match(e)){sub.Out_RequestSellItem(e);}
                //else if (Extension.Out.RequestTags.Match(e)){sub.Out_RequestTags(e);}
                //else if (Extension.Out.RequestTalenTrack.Match(e)){sub.Out_RequestTalenTrack(e);}
                //else if (Extension.Out.RequestTargetOffer.Match(e)){sub.Out_RequestTargetOffer(e);}
                //else if (Extension.Out.RequestUserCitizinShip.Match(e)){sub.Out_RequestUserCitizinShip(e);}
                //else if (Extension.Out.RequestUserClub.Match(e)){sub.Out_RequestUserClub(e);}
                //else if (Extension.Out.RequestUserCredits.Match(e)){sub.Out_RequestUserCredits(e);}
                //else if (Extension.Out.RequestUserData.Match(e)){sub.Out_RequestUserData(e);}
                //else if (Extension.Out.RequestUserProfile.Match(e)){sub.Out_RequestUserProfile(e);}
                //else if (Extension.Out.RequestUserTags.Match(e)){sub.Out_RequestUserTags(e);}
                //else if (Extension.Out.RequestUserWardrobe.Match(e)){sub.Out_RequestUserWardrobe(e);}
                else if (Extension.Out.RequestWearingBadges.Match(e)) { sub.Out_RequestWearingBadges(e); }
                else if (Extension.Out.RoomBackground.Match(e)) { sub.Out_RoomBackground(e); }
                //else if (Extension.Out.RoomFavorite.Match(e)){sub.Out_RoomFavorite(e);}
                //else if (Extension.Out.RoomMute.Match(e)){sub.Out_RoomMute(e);}
                else if (Extension.Out.RoomPickupItem.Match(e)) { sub.Out_RoomPickupItem(e); }
                //else if (Extension.Out.RoomPlaceBuildersClubItem.Match(e)){sub.Out_RoomPlaceBuildersClubItem(e);}
                else if (Extension.Out.RoomPlaceItem.Match(e)) { sub.Out_RoomPlaceItem(e); }
                //else if (Extension.Out.RoomPlacePaint.Match(e)){sub.Out_RoomPlacePaint(e);}
                //else if (Extension.Out.RoomRemoveAllRights.Match(e)){sub.Out_RoomRemoveAllRights(e);}
                //else if (Extension.Out.RoomRemoveRights.Match(e)){sub.Out_RoomRemoveRights(e);}
                else if (Extension.Out.RoomRequestBannedUsers.Match(e)) { sub.Out_RoomRequestBannedUsers(e); }
                //else if (Extension.Out.RoomSettingsSave.Match(e)){sub.Out_RoomSettingsSave(e);}
                //else if (Extension.Out.RoomStaffPick.Match(e)){sub.Out_RoomStaffPick(e);}
                //else if (Extension.Out.RoomUserAction.Match(e)){sub.Out_RoomUserAction(e);}
                //else if (Extension.Out.RoomUserBan.Match(e)){sub.Out_RoomUserBan(e);}
                //else if (Extension.Out.RoomUserDance.Match(e)){sub.Out_RoomUserDance(e);}
                //else if (Extension.Out.RoomUserDropHandItem.Match(e)){sub.Out_RoomUserDropHandItem(e);}
                //else if (Extension.Out.RoomUserGiveHandItem.Match(e)){sub.Out_RoomUserGiveHandItem(e);}
                //else if (Extension.Out.RoomUserGiveRespect.Match(e)){sub.Out_RoomUserGiveRespect(e);}
                //else if (Extension.Out.RoomUserGiveRights.Match(e)){sub.Out_RoomUserGiveRights(e);}
                //else if (Extension.Out.RoomUserKick.Match(e)){sub.Out_RoomUserKick(e);}
                //else if (Extension.Out.RoomUserLookAtPoint.Match(e)){sub.Out_RoomUserLookAtPoint(e);}
                //else if (Extension.Out.RoomUserMute.Match(e)){sub.Out_RoomUserMute(e);}
                //else if (Extension.Out.RoomUserRemoveRights.Match(e)){sub.Out_RoomUserRemoveRights(e);}
                else if (Extension.Out.RoomUserShout.Match(e)) { sub.Out_RoomUserShout(e); }
                //else if (Extension.Out.RoomUserSign.Match(e)){sub.Out_RoomUserSign(e);}
                //else if (Extension.Out.RoomUserSit.Match(e)){sub.Out_RoomUserSit(e);}
                else if (Extension.Out.RoomUserStartTyping.Match(e)) { sub.Out_RoomUserStartTyping(e); }
                //else if (Extension.Out.RoomUserStopTyping.Match(e)){sub.Out_RoomUserStopTyping(e);}
                else if (Extension.Out.RoomUserTalk.Match(e)) { sub.Out_RoomUserTalk(e); }
                else if (Extension.Out.RoomUserWalk.Match(e)) { sub.Out_RoomUserWalk(e); }
                else if (Extension.Out.RoomUserWhisper.Match(e)) { sub.Out_RoomUserWhisper(e); }
                //else if (Extension.Out.RoomVote.Match(e)){sub.Out_RoomVote(e);}
                //else if (Extension.Out.RoomWordFilterModify.Match(e)){sub.Out_RoomWordFilterModify(e);}
                else if (Extension.Out.RotateMoveItem.Match(e)) { sub.Out_RotateMoveItem(e); }
                //else if (Extension.Out.SSOTicket.Match(e)){sub.Out_SSOTicket(e);}
                //else if (Extension.Out.SaveBlockCameraFollow.Match(e)){sub.Out_SaveBlockCameraFollow(e);}
                //else if (Extension.Out.SaveIgnoreRoomInvites.Match(e)){sub.Out_SaveIgnoreRoomInvites(e);}
                //else if (Extension.Out.SaveMotto.Match(e)){sub.Out_SaveMotto(e);}
                //else if (Extension.Out.SavePostItStickyPole.Match(e)){sub.Out_SavePostItStickyPole(e);}
                //else if (Extension.Out.SavePreferOldChat.Match(e)){sub.Out_SavePreferOldChat(e);}
                //else if (Extension.Out.SaveUserVolumes.Match(e)){sub.Out_SaveUserVolumes(e);}
                //else if (Extension.Out.SaveWardrobe.Match(e)){sub.Out_SaveWardrobe(e);}
                //else if (Extension.Out.SaveWindowSettings.Match(e)){sub.Out_SaveWindowSettings(e);}
                //else if (Extension.Out.ScratchPet.Match(e)){sub.Out_ScratchPet(e);}
                //else if (Extension.Out.SearchRooms.Match(e)){sub.Out_SearchRooms(e);}
                //else if (Extension.Out.SearchRoomsByTag.Match(e)){sub.Out_SearchRoomsByTag(e);}
                //else if (Extension.Out.SearchRoomsFriendsNow.Match(e)){sub.Out_SearchRoomsFriendsNow(e);}
                //else if (Extension.Out.SearchRoomsFriendsOwn.Match(e)){sub.Out_SearchRoomsFriendsOwn(e);}
                //else if (Extension.Out.SearchRoomsInGroup.Match(e)){sub.Out_SearchRoomsInGroup(e);}
                //else if (Extension.Out.SearchRoomsMyFavorite.Match(e)){sub.Out_SearchRoomsMyFavorite(e);}
                //else if (Extension.Out.SearchRoomsVisited.Match(e)){sub.Out_SearchRoomsVisited(e);}
                //else if (Extension.Out.SearchRoomsWithRights.Match(e)){sub.Out_SearchRoomsWithRights(e);}
                //else if (Extension.Out.SearchUser.Match(e)){sub.Out_SearchUser(e);}
                //else if (Extension.Out.SellItem.Match(e)){sub.Out_SellItem(e);}
                //else if (Extension.Out.SetHomeRoom.Match(e)){sub.Out_SetHomeRoom(e);}
                else if (Extension.Out.SetStackHelperHeight.Match(e)) { sub.Out_SetStackHelperHeight(e); }
                //else if (Extension.Out.StalkFriend.Match(e)){sub.Out_StalkFriend(e);}
                //else if (Extension.Out.TakeBackItem.Match(e)){sub.Out_TakeBackItem(e);}
                //else if (Extension.Out.TestInventory.Match(e)){sub.Out_TestInventory(e);}
                else if (Extension.Out.ToggleHFloorObject.Match(e)) { sub.Out_ToggleHFloorObject(e); }
                //else if (Extension.Out.ToggleMonsterplantBreedable.Match(e)){sub.Out_ToggleMonsterplantBreedable(e);}
                else if (Extension.Out.ToggleWallItem.Match(e)) { sub.Out_ToggleWallItem(e); }
                //else if (Extension.Out.TradeAccept.Match(e)){sub.Out_TradeAccept(e);}
                //else if (Extension.Out.TradeCancelOfferItem.Match(e)){sub.Out_TradeCancelOfferItem(e);}
                //else if (Extension.Out.TradeClose.Match(e)){sub.Out_TradeClose(e);}
                //else if (Extension.Out.TradeConfirm.Match(e)){sub.Out_TradeConfirm(e);}
                //else if (Extension.Out.TradeOfferItem.Match(e)){sub.Out_TradeOfferItem(e);}
                //else if (Extension.Out.TradeOfferMultipleItems.Match(e)){sub.Out_TradeOfferMultipleItems(e);}
                else if (Extension.Out.TradeStart.Match(e)) { sub.Out_TradeStart(e); }
                //else if (Extension.Out.TradeUnAccept.Match(e)){sub.Out_TradeUnAccept(e);}
                else if (Extension.Out.TriggerColorWheel.Match(e)) { sub.Out_TriggerColorWheel(e); }
                else if (Extension.Out.TriggerDice.Match(e)) { sub.Out_TriggerDice(e); }
                //else if (Extension.Out.TriggerOneWayGate.Match(e)){sub.Out_TriggerOneWayGate(e);}
                //else if (Extension.Out.UnIgnoreRoomUser.Match(e)){sub.Out_UnIgnoreRoomUser(e);}
                //else if (Extension.Out.UnbanRoomUser.Match(e)){sub.Out_UnbanRoomUser(e);}
                //else if (Extension.Out.UserActivity.Match(e)){sub.Out_UserActivity(e);}
                //else if (Extension.Out.UserNux.Match(e)){sub.Out_UserNux(e);}
                //else if (Extension.Out.UserSaveLook.Match(e)){sub.Out_UserSaveLook(e);}
                //else if (Extension.Out.UserWearBadge.Match(e)){sub.Out_UserWearBadge(e);}
                else if (Extension.Out.Username.Match(e)) { sub.Out_Username(e); }
                //else if (Extension.Out.WiredConditionSaveData.Match(e)){sub.Out_WiredConditionSaveData(e);}
                //else if (Extension.Out.WiredEffectSaveData.Match(e)){sub.Out_WiredEffectSaveData(e);}
                //else if (Extension.Out.WiredTriggerSaveData.Match(e)){sub.Out_WiredTriggerSaveData(e);}
                //else if (Extension.Out.YoutubeRequestNextVideo.Match(e)){sub.Out_YoutubeRequestNextVideo(e);}
                //else if (Extension.Out.YoutubeRequestPlayList.Match(e)){sub.Out_YoutubeRequestPlayList(e);}
                //else if (Extension.Out.YoutubeRequestVideoData.Match(e)){sub.Out_YoutubeRequestVideoData(e);}
                #endregion

                #region  Incoming

                if (Extension.In.AddHFloorObject.Match(e)) { sub.In_AddHFloorObject(e); }
                //else if (Extension.In.AddHabboItem.Match(e)){sub.In_AddHabboItem(e);}
                //else if (Extension.In.AddPet.Match(e)){sub.In_AddPet(e);}
                //else if (Extension.In.AddUserBadge.Match(e)){sub.In_AddUserBadge(e);}
                else if (Extension.In.AddWallItem.Match(e)) { sub.In_AddWallItem(e); }
                //else (Extension.In.AchievementList.Match(e)){sub.In_AchievementList(e);}
                //else if (Extension.In.AchievementProgress.Match(e)){sub.In_AchievementProgress(e);}
                //else if (Extension.In.AchievementUnlocked.Match(e)){sub.In_AchievementUnlocked(e);}
                //else if (Extension.In.AchievementsConfiguration.Match(e)){sub.In_AchievementsConfiguration(e);}
                //else if (Extension.In.AddBot.Match(e)){sub.In_AddBot(e);}
                //else if (Extension.In.AdventCalendarData.Match(e)){sub.In_AdventCalendarData(e);}
                //else if (Extension.In.AdventCalendarProduct.Match(e)){sub.In_AdventCalendarProduct(e);}
                //else if (Extension.In.AlertLimitedSoldOut.Match(e)){sub.In_AlertLimitedSoldOut(e);}
                //else if (Extension.In.AlertPurchaseFailed.Match(e)){sub.In_AlertPurchaseFailed(e);}
                //else if (Extension.In.AlertPurchaseUnavailable.Match(e)){sub.In_AlertPurchaseUnavailable(e);}
                //else if (Extension.In.BaseJumpJoinQueue.Match(e)){sub.In_BaseJumpJoinQueue(e);}
                //else if (Extension.In.BaseJumpLeaveQueue.Match(e)){sub.In_BaseJumpLeaveQueue(e);}
                //else if (Extension.In.BaseJumpLoadGame.Match(e)){sub.In_BaseJumpLoadGame(e);}
                //else if (Extension.In.BaseJumpLoadGameURL.Match(e)){sub.In_BaseJumpLoadGameURL(e);}
                //else if (Extension.In.BaseJumpUnloadGame.Match(e)){sub.In_BaseJumpUnloadGame(e);}
                //else if (Extension.In.BonusRare.Match(e)){sub.In_BonusRare(e);}
                //else if (Extension.In.BotError.Match(e)){sub.In_BotError(e);}
                //else if (Extension.In.BotSettings.Match(e)){sub.In_BotSettings(e);}
                //else if (Extension.In.BubbleAlert.Match(e)){sub.In_BubbleAlert(e);}
                //else if (Extension.In.BuildersClubExpired.Match(e)){sub.In_BuildersClubExpired(e);}
                //else if (Extension.In.BullyReportClosed.Match(e)){sub.In_BullyReportClosed(e);}
                //else if (Extension.In.BullyReportRequest.Match(e)){sub.In_BullyReportRequest(e);}
                //else if (Extension.In.BullyReportedMessage.Match(e)){sub.In_BullyReportedMessage(e);}
                //else if (Extension.In.CameraCompetitionStatus.Match(e)){sub.In_CameraCompetitionStatus(e);}
                //else if (Extension.In.CameraPrice.Match(e)){sub.In_CameraPrice(e);}
                //else if (Extension.In.CameraPublishWaitMessage.Match(e)){sub.In_CameraPublishWaitMessage(e);}
                //else if (Extension.In.CameraPurchaseSuccesfull.Match(e)){sub.In_CameraPurchaseSuccesfull(e);}
                //else if (Extension.In.CameraRoomThumbnailSaved.Match(e)){sub.In_CameraRoomThumbnailSaved(e);}
                //else if (Extension.In.CameraURL.Match(e)){sub.In_CameraURL(e);}
                //else if (Extension.In.CanCreateEvent.Match(e)){sub.In_CanCreateEvent(e);}
                //else if (Extension.In.CanCreateRoom.Match(e)){sub.In_CanCreateRoom(e);}
                //else if (Extension.In.CantScratchPetNotOldEnough.Match(e)){sub.In_CantScratchPetNotOldEnough(e);}
                //else if (Extension.In.CatalogMode.Match(e)){sub.In_CatalogMode(e);}
                else if (Extension.In.CatalogPage.Match(e)) { sub.In_CatalogPage(e); }
                else if (Extension.In.CatalogPagesList.Match(e)) { sub.In_CatalogPagesList(e); }
                //else if (Extension.In.CatalogSearchResult.Match(e)){sub.In_CatalogSearchResult(e);}
                //else if (Extension.In.CatalogUpdated.Match(e)){sub.In_CatalogUpdated(e);}
                //else if (Extension.In.CfhTopicsMessage.Match(e)){sub.In_CfhTopicsMessage(e);}
                //else if (Extension.In.ChangeNameUpdate.Match(e)){sub.In_ChangeNameUpdate(e);}
                //else if (Extension.In.CloseWebPage.Match(e)){sub.In_CloseWebPage(e);}
                //else if (Extension.In.ClubCenterData.Match(e)){sub.In_ClubCenterData(e);}
                //else if (Extension.In.ClubData.Match(e)){sub.In_ClubData(e);}
                //else if (Extension.In.ClubGiftReceived.Match(e)){sub.In_ClubGiftReceived(e);}
                //else if (Extension.In.ClubGifts.Match(e)){sub.In_ClubGifts(e);}
                //else if (Extension.In.CompetitionEntrySubmitResult.Match(e)){sub.In_CompetitionEntrySubmitResult(e);}
                //else if (Extension.In.ConnectionError.Match(e)){sub.In_ConnectionError(e);}
                //else if (Extension.In.ConvertedForwardToRoom.Match(e)){sub.In_ConvertedForwardToRoom(e);}
                //else if (Extension.In.CraftableProducts.Match(e)){sub.In_CraftableProducts(e);}
                //else if (Extension.In.CraftingComposerFour.Match(e)){sub.In_CraftingComposerFour(e);}
                //else if (Extension.In.CraftingRecipe.Match(e)){sub.In_CraftingRecipe(e);}
                //else if (Extension.In.CraftingResult.Match(e)){sub.In_CraftingResult(e);}
                //else if (Extension.In.CustomNotification.Match(e)){sub.In_CustomNotification(e);}
                //else if (Extension.In.DailyQuest.Match(e)){sub.In_DailyQuest(e);}
                //else if (Extension.In.DebugConsole.Match(e)){sub.In_DebugConsole(e);}
                //else if (Extension.In.Discount.Match(e)){sub.In_Discount(e);}
                //else if (Extension.In.DoorbellAddUser.Match(e)){sub.In_DoorbellAddUser(e);}
                //else if (Extension.In.EffectsListAdd.Match(e)){sub.In_EffectsListAdd(e);}
                //else if (Extension.In.EffectsListEffectEnable.Match(e)){sub.In_EffectsListEffectEnable(e);}
                //else if (Extension.In.EffectsListRemove.Match(e)){sub.In_EffectsListRemove(e);}
                //else if (Extension.In.EpicPopupFrame.Match(e)){sub.In_EpicPopupFrame(e);}
                //else if (Extension.In.ErrorLogin.Match(e)){sub.In_ErrorLogin(e);}
                //else if (Extension.In.ExtendClubMessage.Match(e)){sub.In_ExtendClubMessage(e);}
                //else if (Extension.In.FavoriteRoomChanged.Match(e)){sub.In_FavoriteRoomChanged(e);}
                //else if (Extension.In.FavoriteRoomsCount.Match(e)){sub.In_FavoriteRoomsCount(e);}
                //else if (Extension.In.FloodCounter.Match(e)){sub.In_FloodCounter(e);}
                else if (Extension.In.HFloorObjectUpdate.Match(e)) { sub.In_HFloorObjectUpdate(e); }
                //else if (Extension.In.FloorPlanEditorBlockedTiles.Match(e)){sub.In_FloorPlanEditorBlockedTiles(e);}
                //else if (Extension.In.FloorPlanEditorDoorSettings.Match(e)){sub.In_FloorPlanEditorDoorSettings(e);}
                //else if (Extension.In.ForwardToRoom.Match(e)){sub.In_ForwardToRoom(e);}
                //else if (Extension.In.FreezeLives.Match(e)){sub.In_FreezeLives(e);}
                //else if (Extension.In.FriendChatMessage.Match(e)){sub.In_FriendChatMessage(e);}
                //else if (Extension.In.FriendFindingRoom.Match(e)){sub.In_FriendFindingRoom(e);}
                //else if (Extension.In.FriendRequest.Match(e)){sub.In_FriendRequest(e);}
                //else if (Extension.In.FriendRequestError.Match(e)){sub.In_FriendRequestError(e);}
                //else if (Extension.In.FriendToolbarNotification.Match(e)){sub.In_FriendToolbarNotification(e);}
                //else if (Extension.In.Friends.Match(e)){sub.In_Friends(e);}
                //else if (Extension.In.Game2WeeklyLeaderboard.Match(e)){sub.In_Game2WeeklyLeaderboard(e);}
                //else if (Extension.In.Game2WeeklySmallLeaderboard.Match(e)){sub.In_Game2WeeklySmallLeaderboard(e);}
                //else if (Extension.In.GameAchievementsList.Match(e)){sub.In_GameAchievementsList(e);}
                //else if (Extension.In.GameCenterAccountInfo.Match(e)){sub.In_GameCenterAccountInfo(e);}
                //else if (Extension.In.GameCenterFeaturedPlayers.Match(e)){sub.In_GameCenterFeaturedPlayers(e);}
                //else if (Extension.In.GameCenterGame.Match(e)){sub.In_GameCenterGame(e);}
                //else if (Extension.In.GameCenterGameList.Match(e)){sub.In_GameCenterGameList(e);}
                //else if (Extension.In.GenerateSecretKey.Match(e)){sub.In_GenerateSecretKey(e);}
                //else if (Extension.In.GenericAlert.Match(e)){sub.In_GenericAlert(e);}
                else if (Extension.In.GenericErrorMessages.Match(e)) { sub.In_GenericErrorMessages(e); }
                //else if (Extension.In.GiftConfiguration.Match(e)){sub.In_GiftConfiguration(e);}
                //else if (Extension.In.GiftReceiverNotFound.Match(e)){sub.In_GiftReceiverNotFound(e);}
                //else if (Extension.In.GroupParts.Match(e)){sub.In_GroupParts(e);}
                //else if (Extension.In.GuardianNewReportReceived.Match(e)){sub.In_GuardianNewReportReceived(e);}
                //else if (Extension.In.GuardianVotingRequested.Match(e)){sub.In_GuardianVotingRequested(e);}
                //else if (Extension.In.GuardianVotingResult.Match(e)){sub.In_GuardianVotingResult(e);}
                //else if (Extension.In.GuardianVotingTimeEnded.Match(e)){sub.In_GuardianVotingTimeEnded(e);}
                //else if (Extension.In.GuardianVotingVotes.Match(e)){sub.In_GuardianVotingVotes(e);}
                //else if (Extension.In.GuideSessionAttached.Match(e)){sub.In_GuideSessionAttached(e);}
                //else if (Extension.In.GuideSessionDetached.Match(e)){sub.In_GuideSessionDetached(e);}
                //else if (Extension.In.GuideSessionEnded.Match(e)){sub.In_GuideSessionEnded(e);}
                //else if (Extension.In.GuideSessionError.Match(e)){sub.In_GuideSessionError(e);}
                //else if (Extension.In.GuideSessionInvitedToGuideRoom.Match(e)){sub.In_GuideSessionInvitedToGuideRoom(e);}
                //else if (Extension.In.GuideSessionMessage.Match(e)){sub.In_GuideSessionMessage(e);}
                //else if (Extension.In.GuideSessionPartnerIsPlaying.Match(e)){sub.In_GuideSessionPartnerIsPlaying(e);}
                //else if (Extension.In.GuideSessionPartnerIsTyping.Match(e)){sub.In_GuideSessionPartnerIsTyping(e);}
                //else if (Extension.In.GuideSessionRequesterRoom.Match(e)){sub.In_GuideSessionRequesterRoom(e);}
                //else if (Extension.In.GuideSessionStarted.Match(e)){sub.In_GuideSessionStarted(e);}
                //else if (Extension.In.GuideTools.Match(e)){sub.In_GuideTools(e);}
                //else if (Extension.In.GuildAcceptMemberError.Match(e)){sub.In_GuildAcceptMemberError(e);}
                //else if (Extension.In.GuildBought.Match(e)){sub.In_GuildBought(e);}
                //else if (Extension.In.GuildBuyRooms.Match(e)){sub.In_GuildBuyRooms(e);}
                //else if (Extension.In.GuildConfirmRemoveMember.Match(e)){sub.In_GuildConfirmRemoveMember(e);}
                //else if (Extension.In.GuildEditFail.Match(e)){sub.In_GuildEditFail(e);}
                //else if (Extension.In.GuildFavoriteRoomUserUpdate.Match(e)){sub.In_GuildFavoriteRoomUserUpdate(e);}
                //else if (Extension.In.GuildForumAddComment.Match(e)){sub.In_GuildForumAddComment(e);}
                //else if (Extension.In.GuildForumComments.Match(e)){sub.In_GuildForumComments(e);}
                //else if (Extension.In.GuildForumData.Match(e)){sub.In_GuildForumData(e);}
                //else if (Extension.In.GuildForumList.Match(e)){sub.In_GuildForumList(e);}
                //else if (Extension.In.GuildForumThreadMessages.Match(e)){sub.In_GuildForumThreadMessages(e);}
                //else if (Extension.In.GuildForumThreads.Match(e)){sub.In_GuildForumThreads(e);}
                //else if (Extension.In.GuildForumsUnreadMessagesCount.Match(e)){sub.In_GuildForumsUnreadMessagesCount(e);}
                //else if (Extension.In.GuildFurniWidget.Match(e)){sub.In_GuildFurniWidget(e);}
                //else if (Extension.In.GuildInfo.Match(e)){sub.In_GuildInfo(e);}
                //else if (Extension.In.GuildJoinError.Match(e)){sub.In_GuildJoinError(e);}
                //else if (Extension.In.GuildList.Match(e)){sub.In_GuildList(e);}
                //else if (Extension.In.GuildManage.Match(e)){sub.In_GuildManage(e);}
                //else if (Extension.In.GuildMemberUpdate.Match(e)){sub.In_GuildMemberUpdate(e);}
                //else if (Extension.In.GuildMembers.Match(e)){sub.In_GuildMembers(e);}
                //else if (Extension.In.GuildRefreshMembersList.Match(e)){sub.In_GuildRefreshMembersList(e);}
                //else if (Extension.In.HabboMall.Match(e)){sub.In_HabboMall(e);}
                //else if (Extension.In.HabboWayQuizComposer1.Match(e)){sub.In_HabboWayQuizComposer1(e);}
                //else if (Extension.In.HabboWayQuizComposer2.Match(e)){sub.In_HabboWayQuizComposer2(e);}
                //else if (Extension.In.HallOfFame.Match(e)){sub.In_HallOfFame(e);}
                //else if (Extension.In.HelperRequestDisabled.Match(e)){sub.In_HelperRequestDisabled(e);}
                //else if (Extension.In.HideDoorbell.Match(e)){sub.In_HideDoorbell(e);}
                //else if (Extension.In.HotelClosedAndOpens.Match(e)){sub.In_HotelClosedAndOpens(e);}
                //else if (Extension.In.HotelClosesAndWillOpenAt.Match(e)){sub.In_HotelClosesAndWillOpenAt(e);}
                else if (Extension.In.HotelView.Match(e)) { sub.In_HotelView(e); }
                //else if (Extension.In.HotelViewBadgeButtonConfig.Match(e)){sub.In_HotelViewBadgeButtonConfig(e);}
                //else if (Extension.In.HotelViewCatalogPageExpiring.Match(e)){sub.In_HotelViewCatalogPageExpiring(e);}
                //else if (Extension.In.HotelViewCommunityGoal.Match(e)){sub.In_HotelViewCommunityGoal(e);}
                //else if (Extension.In.HotelViewConcurrentUsers.Match(e)){sub.In_HotelViewConcurrentUsers(e);}
                //else if (Extension.In.HotelViewCustomTimer.Match(e)){sub.In_HotelViewCustomTimer(e);}
                //else if (Extension.In.HotelViewData.Match(e)){sub.In_HotelViewData(e);}
                //else if (Extension.In.HotelViewExpiringCatalogPageCommposer.Match(e)){sub.In_HotelViewExpiringCatalogPageCommposer(e);}
                //else if (Extension.In.HotelViewHideCommunityVoteButton.Match(e)){sub.In_HotelViewHideCommunityVoteButton(e);}
                //else if (Extension.In.HotelViewNextLTDAvailable.Match(e)){sub.In_HotelViewNextLTDAvailable(e);}
                //else if (Extension.In.HotelWillCloseInMinutes.Match(e)){sub.In_HotelWillCloseInMinutes(e);}
                //else if (Extension.In.HotelWillCloseInMinutesAndBackIn.Match(e)){sub.In_HotelWillCloseInMinutesAndBackIn(e);}
                //else if (Extension.In.InventoryAchievements.Match(e)){sub.In_InventoryAchievements(e);}
                //else if (Extension.In.InventoryAddEffect.Match(e)){sub.In_InventoryAddEffect(e);}
                //else if (Extension.In.InventoryBadges.Match(e)){sub.In_InventoryBadges(e);}
                //else if (Extension.In.InventoryBots.Match(e)){sub.In_InventoryBots(e);}
                //else if (Extension.In.InventoryItemUpdate.Match(e)){sub.In_InventoryItemUpdate(e);}
                //else if (Extension.In.InventoryItems.Match(e)){sub.In_InventoryItems(e);}
                //else if (Extension.In.InventoryPets.Match(e)){sub.In_InventoryPets(e);}
                //else if (Extension.In.InventoryRefresh.Match(e)){sub.In_InventoryRefresh(e);}
                else if (Extension.In.ItemExtraData.Match(e)) { sub.In_ItemExtraData(e); }
                //else if (Extension.In.ItemState.Match(e)){sub.In_ItemState(e);}
                //else if (Extension.In.ItemStateComposer2.Match(e)){sub.In_ItemStateComposer2(e);}
                //else if (Extension.In.ItemsDataUpdate.Match(e)){sub.In_ItemsDataUpdate(e);}
                //else if (Extension.In.JukeBoxMySongs.Match(e)){sub.In_JukeBoxMySongs(e);}
                //else if (Extension.In.JukeBoxNowPlayingMessage.Match(e)){sub.In_JukeBoxNowPlayingMessage(e);}
                //else if (Extension.In.JukeBoxPlayList.Match(e)){sub.In_JukeBoxPlayList(e);}
                //else if (Extension.In.JukeBoxPlayListAddSong.Match(e)){sub.In_JukeBoxPlayListAddSong(e);}
                //else if (Extension.In.JukeBoxPlayListUpdated.Match(e)){sub.In_JukeBoxPlayListUpdated(e);}
                //else if (Extension.In.JukeBoxPlaylistFull.Match(e)){sub.In_JukeBoxPlaylistFull(e);}
                //else if (Extension.In.JukeBoxTrackCode.Match(e)){sub.In_JukeBoxTrackCode(e);}
                //else if (Extension.In.JukeBoxTrackData.Match(e)){sub.In_JukeBoxTrackData(e);}
                //else if (Extension.In.LatencyResponse.Match(e)){sub.In_LatencyResponse(e);}
                //else if (Extension.In.LeprechaunStarterBundle.Match(e)){sub.In_LeprechaunStarterBundle(e);}
                //else if (Extension.In.LoadFriendRequests.Match(e)){sub.In_LoadFriendRequests(e);}
                //else if (Extension.In.LoveLockFurniFinished.Match(e)){sub.In_LoveLockFurniFinished(e);}
                //else if (Extension.In.LoveLockFurniFriendConfirmed.Match(e)){sub.In_LoveLockFurniFriendConfirmed(e);}
                //else if (Extension.In.LoveLockFurniStart.Match(e)){sub.In_LoveLockFurniStart(e);}
                //else if (Extension.In.MachineID.Match(e)){sub.In_MachineID(e);}
                //else if (Extension.In.MarketplaceBuyError.Match(e)){sub.In_MarketplaceBuyError(e);}
                //else if (Extension.In.MarketplaceCancelSale.Match(e)){sub.In_MarketplaceCancelSale(e);}
                //else if (Extension.In.MarketplaceConfig.Match(e)){sub.In_MarketplaceConfig(e);}
                //else if (Extension.In.MarketplaceItemInfo.Match(e)){sub.In_MarketplaceItemInfo(e);}
                //else if (Extension.In.MarketplaceItemPosted.Match(e)){sub.In_MarketplaceItemPosted(e);}
                //else if (Extension.In.MarketplaceOffers.Match(e)){sub.In_MarketplaceOffers(e);}
                //else if (Extension.In.MarketplaceOwnItems.Match(e)){sub.In_MarketplaceOwnItems(e);}
                //else if (Extension.In.MarketplaceSellItem.Match(e)){sub.In_MarketplaceSellItem(e);}
                //else if (Extension.In.MeMenuSettings.Match(e)){sub.In_MeMenuSettings(e);}
                else if (Extension.In.MessagesForYou.Match(e)) { sub.In_MessagesForYou(e); }
                //else if (Extension.In.MessengerError.Match(e)){sub.In_MessengerError(e);}
                //else if (Extension.In.MessengerInit.Match(e)){sub.In_MessengerInit(e);}
                //else if (Extension.In.MinimailCount.Match(e)){sub.In_MinimailCount(e);}
                //else if (Extension.In.MinimailNewMessage.Match(e)){sub.In_MinimailNewMessage(e);}
                //else if (Extension.In.ModTool.Match(e)){sub.In_ModTool(e);}
                //else if (Extension.In.ModToolComposerOne.Match(e)){sub.In_ModToolComposerOne(e);}
                //else if (Extension.In.ModToolComposerTwo.Match(e)){sub.In_ModToolComposerTwo(e);}
                //else if (Extension.In.ModToolIssueChatlog.Match(e)){sub.In_ModToolIssueChatlog(e);}
                //else if (Extension.In.ModToolIssueHandled.Match(e)){sub.In_ModToolIssueHandled(e);}
                //else if (Extension.In.ModToolIssueHandlerDimensions.Match(e)){sub.In_ModToolIssueHandlerDimensions(e);}
                //else if (Extension.In.ModToolIssueInfo.Match(e)){sub.In_ModToolIssueInfo(e);}
                //else if (Extension.In.ModToolIssueResponseAlert.Match(e)){sub.In_ModToolIssueResponseAlert(e);}
                //else if (Extension.In.ModToolIssueUpdate.Match(e)){sub.In_ModToolIssueUpdate(e);}
                //else if (Extension.In.ModToolReportReceivedAlert.Match(e)){sub.In_ModToolReportReceivedAlert(e);}
                else if (Extension.In.ModToolRoomChatlog.Match(e)) { sub.In_ModToolRoomChatlog(e); }
                //else if (Extension.In.ModToolRoomInfo.Match(e)){sub.In_ModToolRoomInfo(e);}
                //else if (Extension.In.ModToolSanctionData.Match(e)){sub.In_ModToolSanctionData(e);}
                //else if (Extension.In.ModToolSanctionInfo.Match(e)){sub.In_ModToolSanctionInfo(e);}
                //else if (Extension.In.ModToolUserChatlog.Match(e)){sub.In_ModToolUserChatlog(e);}
                //else if (Extension.In.ModToolUserInfo.Match(e)){sub.In_ModToolUserInfo(e);}
                //else if (Extension.In.ModToolUserRoomVisits.Match(e)){sub.In_ModToolUserRoomVisits(e);}
                //else if (Extension.In.MoodLightData.Match(e)){sub.In_MoodLightData(e);}
                //else if (Extension.In.MutedWhisper.Match(e)){sub.In_MutedWhisper(e);}
                //else if (Extension.In.MysticBoxClose.Match(e)){sub.In_MysticBoxClose(e);}
                //else if (Extension.In.MysticBoxPrize.Match(e)){sub.In_MysticBoxPrize(e);}
                //else if (Extension.In.MysticBoxStartOpen.Match(e)){sub.In_MysticBoxStartOpen(e);}
                //else if (Extension.In.NewNavigatorCategoryUserCount.Match(e)){sub.In_NewNavigatorCategoryUserCount(e);}
                //else if (Extension.In.NewNavigatorCollapsedCategories.Match(e)){sub.In_NewNavigatorCollapsedCategories(e);}
                //else if (Extension.In.NewNavigatorEventCategories.Match(e)){sub.In_NewNavigatorEventCategories(e);}
                //else if (Extension.In.NewNavigatorLiftedRooms.Match(e)){sub.In_NewNavigatorLiftedRooms(e);}
                //else if (Extension.In.NewNavigatorMetaData.Match(e)){sub.In_NewNavigatorMetaData(e);}
                //else if (Extension.In.NewNavigatorRoomEvent.Match(e)){sub.In_NewNavigatorRoomEvent(e);}
                //else if (Extension.In.NewNavigatorSavedSearches.Match(e)){sub.In_NewNavigatorSavedSearches(e);}
                else if (Extension.In.NewNavigatorSearchResults.Match(e)) { sub.In_NewNavigatorSearchResults(e); }
                //else if (Extension.In.NewNavigatorSettings.Match(e)){sub.In_NewNavigatorSettings(e);}
                //else if (Extension.In.NewUserGift.Match(e)){sub.In_NewUserGift(e);}
                //else if (Extension.In.NewUserIdentity.Match(e)){sub.In_NewUserIdentity(e);}
                //else if (Extension.In.NewYearResolution.Match(e)){sub.In_NewYearResolution(e);}
                //else if (Extension.In.NewYearResolutionCompleted.Match(e)){sub.In_NewYearResolutionCompleted(e);}
                //else if (Extension.In.NewYearResolutionProgress.Match(e)){sub.In_NewYearResolutionProgress(e);}
                //else if (Extension.In.NewsWidgets.Match(e)){sub.In_NewsWidgets(e);}
                //else if (Extension.In.NotEnoughPointsType.Match(e)){sub.In_NotEnoughPointsType(e);}
                //else if (Extension.In.NuxAlert.Match(e)){sub.In_NuxAlert(e);}
                //else if (Extension.In.ObjectOnRoller.Match(e)){sub.In_ObjectOnRoller(e);}
                //else if (Extension.In.OldPublicRooms.Match(e)){sub.In_OldPublicRooms(e);}
                //else if (Extension.In.OpenRoomCreationWindow.Match(e)){sub.In_OpenRoomCreationWindow(e);}
                //else if (Extension.In.OtherTradingDisabled.Match(e)){sub.In_OtherTradingDisabled(e);}
                //else if (Extension.In.PetBoughtNotification.Match(e)){sub.In_PetBoughtNotification(e);}
                //else if (Extension.In.PetBreedingCompleted.Match(e)){sub.In_PetBreedingCompleted(e);}
                //else if (Extension.In.PetBreedingFailed.Match(e)){sub.In_PetBreedingFailed(e);}
                //else if (Extension.In.PetBreedingResult.Match(e)){sub.In_PetBreedingResult(e);}
                //else if (Extension.In.PetBreedingStart.Match(e)){sub.In_PetBreedingStart(e);}
                //else if (Extension.In.PetBreedingStartFailed.Match(e)){sub.In_PetBreedingStartFailed(e);}
                //else if (Extension.In.PetBreeds.Match(e)){sub.In_PetBreeds(e);}
                //else if (Extension.In.PetError.Match(e)){sub.In_PetError(e);}
                //else if (Extension.In.PetInfo.Match(e)){sub.In_PetInfo(e);}
                //else if (Extension.In.PetLevelUp.Match(e)){sub.In_PetLevelUp(e);}
                //else if (Extension.In.PetLevelUpdated.Match(e)){sub.In_PetLevelUpdated(e);}
                //else if (Extension.In.PetNameError.Match(e)){sub.In_PetNameError(e);}
                //else if (Extension.In.PetPackageNameValidation.Match(e)){sub.In_PetPackageNameValidation(e);}
                //else if (Extension.In.PetStatusUpdate.Match(e)){sub.In_PetStatusUpdate(e);}
                //else if (Extension.In.PetTrainingPanel.Match(e)){sub.In_PetTrainingPanel(e);}
                //else if (Extension.In.PickMonthlyClubGiftNotification.Match(e)){sub.In_PickMonthlyClubGiftNotification(e);}
                //else if (Extension.In.Ping.Match(e)){sub.In_Ping(e);}
                //else if (Extension.In.PollQuestions.Match(e)){sub.In_PollQuestions(e);}
                //else if (Extension.In.PollStart.Match(e)){sub.In_PollStart(e);}
                //else if (Extension.In.PostItData.Match(e)){sub.In_PostItData(e);}
                //else if (Extension.In.PostItStickyPoleOpen.Match(e)){sub.In_PostItStickyPoleOpen(e);}
                //else if (Extension.In.PresentItemOpened.Match(e)){sub.In_PresentItemOpened(e);}
                //else if (Extension.In.PrivateRooms.Match(e)){sub.In_PrivateRooms(e);}
                //else if (Extension.In.PrivateMessageAlert.Match(e)){sub.In_PrivateMessageAlert(e);}
                //else if (Extension.In.ProfileFriends.Match(e)){sub.In_ProfileFriends(e);}
                //else if (Extension.In.PromoteOwnRoomsList.Match(e)){sub.In_PromoteOwnRoomsList(e);}
                //else if (Extension.In.PublicRooms.Match(e)){sub.In_PublicRooms(e);}
                else if (Extension.In.PurchaseOK.Match(e)) { sub.In_PurchaseOK(e); }
                //else if (Extension.In.QuestCompleted.Match(e)){sub.In_QuestCompleted(e);}
                //else if (Extension.In.QuestExpired.Match(e)){sub.In_QuestExpired(e);}
                //else if (Extension.In.ReceiveInvitation.Match(e)){sub.In_ReceiveInvitation(e);}
                else if (Extension.In.ReceivePrivateMessage.Match(e)) { sub.In_ReceivePrivateMessage(e); }
                //else if (Extension.In.RecyclerComplete.Match(e)){sub.In_RecyclerComplete(e);}
                //else if (Extension.In.RecyclerLogic.Match(e)){sub.In_RecyclerLogic(e);}
                //else if (Extension.In.RedeemVoucherError.Match(e)){sub.In_RedeemVoucherError(e);}
                //else if (Extension.In.RedeemVoucherOK.Match(e)){sub.In_RedeemVoucherOK(e);}
                //else if (Extension.In.ReloadRecycler.Match(e)){sub.In_ReloadRecycler(e);}
                //else if (Extension.In.RemoveBot.Match(e)){sub.In_RemoveBot(e);}
                else if (Extension.In.RemoveHFloorObject.Match(e)) { sub.In_RemoveHFloorObject(e); }
                else if (Extension.In.RemoveFriend.Match(e)) { sub.In_RemoveFriend(e); }
                //else if (Extension.In.RemoveGuildFromRoom.Match(e)){sub.In_RemoveGuildFromRoom(e);}
                //else if (Extension.In.RemoveHabboItem.Match(e)){sub.In_RemoveHabboItem(e);}
                //else if (Extension.In.RemovePet.Match(e)){sub.In_RemovePet(e);}
                //else if (Extension.In.RemoveRoomEvent.Match(e)){sub.In_RemoveRoomEvent(e);}
                else if (Extension.In.RemoveWallItem.Match(e)) { sub.In_RemoveWallItem(e); }
                //else if (Extension.In.RentableItemBuyOutPrice.Match(e)){sub.In_RentableItemBuyOutPrice(e);}
                //else if (Extension.In.RentableSpaceInfo.Match(e)){sub.In_RentableSpaceInfo(e);}
                //else if (Extension.In.ReportRoomForm.Match(e)){sub.In_ReportRoomForm(e);}
                else if (Extension.In.RoomAccessDenied.Match(e)) { sub.In_RoomAccessDenied(e); }
                //else if (Extension.In.RoomAdError.Match(e)){sub.In_RoomAdError(e);}
                //else if (Extension.In.RoomAddRightsList.Match(e)){sub.In_RoomAddRightsList(e);}
                else if (Extension.In.RoomBannedUsers.Match(e)) { sub.In_RoomBannedUsers(e); }
                //else if (Extension.In.RoomCategories.Match(e)){sub.In_RoomCategories(e);}
                //else if (Extension.In.RoomCategoryUpdateMessage.Match(e)){sub.In_RoomCategoryUpdateMessage(e);}
                //else if (Extension.In.RoomChatSettings.Match(e)){sub.In_RoomChatSettings(e);}
                //else if (Extension.In.RoomCreated.Match(e)){sub.In_RoomCreated(e);}
                else if (Extension.In.RoomData.Match(e)) { sub.In_RoomData(e); }
                //else if (Extension.In.RoomEditSettingsError.Match(e)){sub.In_RoomEditSettingsError(e);}
                else if (Extension.In.RoomEnterError.Match(e)) { sub.In_RoomEnterError(e); }
                //else if (Extension.In.RoomEntryInfo.Match(e)){sub.In_RoomEntryInfo(e);}
                //else if (Extension.In.RoomEventMessage.Match(e)){sub.In_RoomEventMessage(e);}
                //else if (Extension.In.RoomFilterWords.Match(e)){sub.In_RoomFilterWords(e);}
                else if (Extension.In.RoomHFloorObjects.Match(e)) { sub.In_RoomHFloorObjects(e); }
                //else if (Extension.In.RoomFloorThicknessUpdated.Match(e)){sub.In_RoomFloorThicknessUpdated(e);}
                //else if (Extension.In.RoomHeightMap.Match(e)){sub.In_RoomHeightMap(e);}
                //else if (Extension.In.RoomInvite.Match(e)){sub.In_RoomInvite(e);}
                //else if (Extension.In.RoomInviteError.Match(e)){sub.In_RoomInviteError(e);}
                //else if (Extension.In.RoomMessagesPostedCount.Match(e)){sub.In_RoomMessagesPostedCount(e);}
                //else if (Extension.In.RoomModel.Match(e)){sub.In_RoomModel(e);}
                //else if (Extension.In.RoomMuted.Match(e)){sub.In_RoomMuted(e);}
                //else if (Extension.In.RoomNoRights.Match(e)){sub.In_RoomNoRights(e);}
                else if (Extension.In.RoomOpen.Match(e)) { sub.In_RoomOpen(e); }
                //else if (Extension.In.RoomOwner.Match(e)){sub.In_RoomOwner(e);}
                //else if (Extension.In.RoomPaint.Match(e)){sub.In_RoomPaint(e);}
                //else if (Extension.In.RoomPetExperience.Match(e)){sub.In_RoomPetExperience(e);}
                //else if (Extension.In.RoomPetHorseFigure.Match(e)){sub.In_RoomPetHorseFigure(e);}
                //else if (Extension.In.RoomPetRespect.Match(e)){sub.In_RoomPetRespect(e);}
                //else if (Extension.In.RoomRelativeMap.Match(e)){sub.In_RoomRelativeMap(e);}
                //else if (Extension.In.RoomRemoveRightsList.Match(e)){sub.In_RoomRemoveRightsList(e);}
                //else if (Extension.In.RoomRights.Match(e)){sub.In_RoomRights(e);}
                //else if (Extension.In.RoomRightsList.Match(e)){sub.In_RoomRightsList(e);}
                //else if (Extension.In.RoomScore.Match(e)){sub.In_RoomScore(e);}
                //else if (Extension.In.RoomSettings.Match(e)){sub.In_RoomSettings(e);}
                //else if (Extension.In.RoomSettingsSaved.Match(e)){sub.In_RoomSettingsSaved(e);}
                //else if (Extension.In.RoomSettingsUpdated.Match(e)){sub.In_RoomSettingsUpdated(e);}
                //else if (Extension.In.RoomThickness.Match(e)){sub.In_RoomThickness(e);}
                //else if (Extension.In.RoomUnitIdle.Match(e)){sub.In_RoomUnitIdle(e);}
                //else if (Extension.In.RoomUserAction.Match(e)){sub.In_RoomUserAction(e);}
                //else if (Extension.In.RoomUserDance.Match(e)){sub.In_RoomUserDance(e);}
                //else if (Extension.In.RoomUserData.Match(e)){sub.In_RoomUserData(e);}
                else if (Extension.In.RoomUserEffect.Match(e)) { sub.In_RoomUserEffect(e); }
                //else if (Extension.In.RoomUserHandItem.Match(e)){sub.In_RoomUserHandItem(e);}
                //else if (Extension.In.RoomUserIgnored.Match(e)){sub.In_RoomUserIgnored(e);}
                //else if (Extension.In.RoomUserNameChanged.Match(e)){sub.In_RoomUserNameChanged(e);}
                //else if (Extension.In.RoomUserReceivedHandItem.Match(e)){sub.In_RoomUserReceivedHandItem(e);}
                else if (Extension.In.RoomUserRemove.Match(e)) { sub.In_RoomUserRemove(e); }
                //else if (Extension.In.RoomUserRemoveRights.Match(e)){sub.In_RoomUserRemoveRights(e);}
                //else if (Extension.In.RoomUserRespect.Match(e)){sub.In_RoomUserRespect(e);}
                else if (Extension.In.RoomUserShout.Match(e)) { sub.In_RoomUserShout(e); }
                else if (Extension.In.RoomUserStatus.Match(e)) { sub.In_RoomUserStatus(e); }
                //else if (Extension.In.RoomUserTags.Match(e)){sub.In_RoomUserTags(e);}
                else if (Extension.In.RoomUserTalk.Match(e)) { sub.In_RoomUserTalk(e); }
                //else if (Extension.In.RoomUserTyping.Match(e)){sub.In_RoomUserTyping(e);}
                //else if (Extension.In.RoomUserUnbanned.Match(e)){sub.In_RoomUserUnbanned(e);}
                else if (Extension.In.RoomUserWhisper.Match(e)) { sub.In_RoomUserWhisper(e); }
                else if (Extension.In.RoomUsers.Match(e)) { sub.In_RoomUsers(e); }
                //else if (Extension.In.RoomUsersGuildBadges.Match(e)){sub.In_RoomUsersGuildBadges(e);}
                else if (Extension.In.RoomWallItems.Match(e)) { sub.In_RoomWallItems(e); }
                //else if (Extension.In.SecureLoginOK.Match(e)){sub.In_SecureLoginOK(e);}
                //else if (Extension.In.SessionRights.Match(e)){sub.In_SessionRights(e);}
                //else if (Extension.In.SimplePollAnswer.Match(e)){sub.In_SimplePollAnswer(e);}
                //else if (Extension.In.SimplePollAnswers.Match(e)){sub.In_SimplePollAnswers(e);}
                //else if (Extension.In.SimplePollStart.Match(e)){sub.In_SimplePollStart(e);}
                //else if (Extension.In.StaffAlertAndOpenHabboWay.Match(e)){sub.In_StaffAlertAndOpenHabboWay(e);}
                //else if (Extension.In.StaffAlertWIthLinkAndOpenHabboWay.Match(e)){sub.In_StaffAlertWIthLinkAndOpenHabboWay(e);}
                //else if (Extension.In.StaffAlertWithLink.Match(e)){sub.In_StaffAlertWithLink(e);}
                //else if (Extension.In.StalkError.Match(e)){sub.In_StalkError(e);}
                //else if (Extension.In.SubmitCompetitionRoom.Match(e)){sub.In_SubmitCompetitionRoom(e);}
                //else if (Extension.In.Tags.Match(e)){sub.In_Tags(e);}
                //else if (Extension.In.TalentLevelUpdate.Match(e)){sub.In_TalentLevelUpdate(e);}
                //else if (Extension.In.TalentTrack.Match(e)){sub.In_TalentTrack(e);}
                //else if (Extension.In.TalentTrackEmailFailed.Match(e)){sub.In_TalentTrackEmailFailed(e);}
                //else if (Extension.In.TalentTrackEmailVerified.Match(e)){sub.In_TalentTrackEmailVerified(e);}
                //else if (Extension.In.TargetedOffer.Match(e)){sub.In_TargetedOffer(e);}
                //else if (Extension.In.TradeAccepted.Match(e)){sub.In_TradeAccepted(e);}
                //else if (Extension.In.TradeCloseWindow.Match(e)){sub.In_TradeCloseWindow(e);}
                //else if (Extension.In.TradeComplete.Match(e)){sub.In_TradeComplete(e);}
                //else if (Extension.In.TradeStart.Match(e)){sub.In_TradeStart(e);}
                //else if (Extension.In.TradeStartFail.Match(e)){sub.In_TradeStartFail(e);}
                else if (Extension.In.TradeStopped.Match(e)) { sub.In_TradeStopped(e); }
                //else if (Extension.In.TradeUpdate.Match(e)){sub.In_TradeUpdate(e);}
                //else if (Extension.In.TradingWaitingConfirm.Match(e)){sub.In_TradingWaitingConfirm(e);}
                //else if (Extension.In.UpdateFailed.Match(e)){sub.In_UpdateFailed(e);}
                //else if (Extension.In.UpdateFriend.Match(e)){sub.In_UpdateFriend(e);}
                //else if (Extension.In.UpdateStackHeight.Match(e)){sub.In_UpdateStackHeight(e);}
                //else if (Extension.In.UpdateStackHeightTileHeight.Match(e)){sub.In_UpdateStackHeightTileHeight(e);}
                //else if (Extension.In.UpdateUserLook.Match(e)){sub.In_UpdateUserLook(e);}
                //else if (Extension.In.UserAchievementScore.Match(e)){sub.In_UserAchievementScore(e);}
                //else if (Extension.In.UserBadges.Match(e)){sub.In_UserBadges(e);}
                //else if (Extension.In.UserCitizinShip.Match(e)){sub.In_UserCitizinShip(e);}
                //else if (Extension.In.UserClothes.Match(e)){sub.In_UserClothes(e);}
                //else if (Extension.In.UserClub.Match(e)){sub.In_UserClub(e);}
                //else if (Extension.In.UserCredits.Match(e)){sub.In_UserCredits(e);}
                //else if (Extension.In.UserCurrency.Match(e)){sub.In_UserCurrency(e);}
                //else if (Extension.In.UserData.Match(e)){sub.In_UserData(e);}
                //else if (Extension.In.UserEffectsList.Match(e)){sub.In_UserEffectsList(e);}
                //else if (Extension.In.UserHomeRoom.Match(e)){sub.In_UserHomeRoom(e);}
                //else if (Extension.In.UserPerks.Match(e)){sub.In_UserPerks(e);}
                else if (Extension.In.UserPermissions.Match(e)) { sub.In_UserPermissions(e); }
                //else if (Extension.In.UserPoints.Match(e)){sub.In_UserPoints(e);}
                else if (Extension.In.UserProfile.Match(e)) { sub.In_UserProfile(e); }
                //else if (Extension.In.UserSearchResult.Match(e)){sub.In_UserSearchResult(e);}
                //else if (Extension.In.UserWardrobe.Match(e)){sub.In_UserWardrobe(e);}
                //else if (Extension.In.VerifyMobileNumber.Match(e)){sub.In_VerifyMobileNumber(e);}
                //else if (Extension.In.VerifyMobilePhoneCodeWindow.Match(e)){sub.In_VerifyMobilePhoneCodeWindow(e);}
                //else if (Extension.In.VerifyMobilePhoneDone.Match(e)){sub.In_VerifyMobilePhoneDone(e);}
                //else if (Extension.In.VerifyMobilePhoneWindow.Match(e)){sub.In_VerifyMobilePhoneWindow(e);}
                //else if (Extension.In.VerifyPrimes.Match(e)){sub.In_VerifyPrimes(e);}
                //else if (Extension.In.VipTutorialsStart.Match(e)){sub.In_VipTutorialsStart(e);}
                else if (Extension.In.WallItemUpdate.Match(e)) { sub.In_WallItemUpdate(e); }
                //else if (Extension.In.WatchAndEarnReward.Match(e)){sub.In_WatchAndEarnReward(e);}
                //else if (Extension.In.WelcomeGift.Match(e)){sub.In_WelcomeGift(e);}
                //else if (Extension.In.WelcomeGiftError.Match(e)){sub.In_WelcomeGiftError(e);}
                //else if (Extension.In.WiredConditionData.Match(e)){sub.In_WiredConditionData(e);}
                //else if (Extension.In.WiredEffectData.Match(e)){sub.In_WiredEffectData(e);}
                //else if (Extension.In.WiredRewardAlert.Match(e)){sub.In_WiredRewardAlert(e);}
                //else if (Extension.In.WiredSaved.Match(e)){sub.In_WiredSaved(e);}
                //else if (Extension.In.WiredTriggerData.Match(e)){sub.In_WiredTriggerData(e);}
                //else if (Extension.In.YouTradingDisabled.Match(e)){sub.In_YouTradingDisabled(e);}
                //else if (Extension.In.YoutubeDisplayList.Match(e)){sub.In_YoutubeDisplayList(e);}
                //else if (Extension.In.YoutubeMessageComposer2.Match(e)){sub.In_YoutubeMessageComposer2(e);}
                //else if (Extension.In.YoutubeMessageComposer3.Match(e)){sub.In_YoutubeMessageComposer3(e);}

                #endregion
            }
        }

    }
}