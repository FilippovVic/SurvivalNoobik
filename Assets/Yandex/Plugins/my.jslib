mergeInto(LibraryManager.library, {
 
  Show : function() {
    try {
      ysdk.adv.showFullscreenAdv({
      callbacks: {
          onClose: function(wasShown) {

          },
          onError: function(error) {

          }
        }
      })
    } catch (err) {

    }
  },

  GetDataAgain : function() {
    try {
      player.getData().then(_data => {
        const myJSON = JSON.stringify(_data);
        myGameInstance.SendMessage('Progress', 'SetPlayerInfo', myJSON);
      });
    } catch (err) {

    }
  },

  SaveExtern : function(data) {
    try {
      var dataString = UTF8ToString(data);
      var myobj = JSON.parse(dataString);
      player.setData(myobj);  
    } catch (err) {

    }
  },

  SetScoreToLeaderBoard : function(value) {
    ysdk.getLeaderboards()
    .then(lb => {
      lb.setLeaderboardScore('BestScore', value);
    });
  },

  GetLang : function() {
    try {
      var lang = ysdk.environment.i18n.lang;
      var bufferSize = lengthBytesUTF8(lang) + 1;
      var buffer = _malloc(bufferSize);
      stringToUTF8(lang, buffer, bufferSize);
      return buffer;
    } catch(err) {
      
    }
  },

  BuyHoodie : function() {
    payments.purchase({ id: 'sweatshirt' }).then(purchase => {
        // Покупка успешно совершена!
        myGameInstance.SendMessage('InApp', 'SetHoodieTrue');
    }).catch(err => {
        // Покупка не удалась: в консоли разработчика не добавлен товар с таким id,
        // пользователь не авторизовался, передумал и закрыл окно оплаты,
        // истекло отведенное на покупку время, не хватило денег и т. д.
        myGameInstance.SendMessage('InApp', 'SetHoodieFalse');
    })
  },

  BuyAnime : function() {
    payments.purchase({ id: 'anime' }).then(purchase => {
        // Покупка успешно совершена!
        myGameInstance.SendMessage('InApp', 'SetAnimeTrue');
    }).catch(err => {
        // Покупка не удалась: в консоли разработчика не добавлен товар с таким id,
        // пользователь не авторизовался, передумал и закрыл окно оплаты,
        // истекло отведенное на покупку время, не хватило денег и т. д.
        myGameInstance.SendMessage('InApp', 'SetAnimeFalse');
    })
  },

  BuyCrown : function() {
    payments.purchase({ id: 'crown' }).then(purchase => {
        // Покупка успешно совершена!
        myGameInstance.SendMessage('InApp', 'SetCrownTrue');
    }).catch(err => {
        // Покупка не удалась: в консоли разработчика не добавлен товар с таким id,
        // пользователь не авторизовался, передумал и закрыл окно оплаты,
        // истекло отведенное на покупку время, не хватило денег и т. д.
        myGameInstance.SendMessage('InApp', 'SetCrownFalse');
    })
  },

  CheckPayments : function() {
    payments.getPurchases().then(purchases => {
        if (purchases.some(purchase => purchase.productID === 'sweatshirt')) {
          myGameInstance.SendMessage('InApp', 'SetHoodieTrue');
        } else {
          myGameInstance.SendMessage('InApp', 'SetHoodieFalse');
        }
        if (purchases.some(purchase => purchase.productID === 'anime')) {
          myGameInstance.SendMessage('InApp', 'SetAnimeTrue');
        } else {
          myGameInstance.SendMessage('InApp', 'SetAnimeFalse');
        }
        if (purchases.some(purchase => purchase.productID === 'crown')) {
          myGameInstance.SendMessage('InApp', 'SetCrownTrue');
        }
        else {
          myGameInstance.SendMessage('InApp', 'SetCrownFalse');
        }
    }).catch(err => {
        // Выбрасывает исключение USER_NOT_AUTHORIZED для неавторизованных пользователей.
    })
  },

});