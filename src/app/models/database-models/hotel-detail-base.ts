import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class HotelDetailBase {

//#region hotelDetailId Prop
        @prop()
        hotelDetailId : number;
//#endregion hotelDetailId Prop


//#region hotelId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        hotelId : number;
//#endregion hotelId Prop


//#region hotelDetails Prop
        @required()
        @maxLength({value:50})
        hotelDetails : string;
//#endregion hotelDetails Prop


//#region floors Prop
        @required()
        @maxLength({value:50})
        floors : string;
//#endregion floors Prop


//#region reviewId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        reviewId : number;
//#endregion reviewId Prop


//#region starCategory Prop
        @required()
        @maxLength({value:50})
        starCategory : string;
//#endregion starCategory Prop


//#region userRating Prop
        @required()
        @maxLength({value:50})
        userRating : string;
//#endregion userRating Prop







}