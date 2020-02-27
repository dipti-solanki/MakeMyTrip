import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class HotelBookingBase {

//#region hotelBookingId Prop
        @prop()
        hotelBookingId : number;
//#endregion hotelBookingId Prop


//#region travellerId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        travellerId : number;
//#endregion travellerId Prop


//#region hotelDetailId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        hotelDetailId : number;
//#endregion hotelDetailId Prop


//#region offerId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        offerId : number;
//#endregion offerId Prop


//#region amount Prop
        @required()
        amount : number;
//#endregion amount Prop



}