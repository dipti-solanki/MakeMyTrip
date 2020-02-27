import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class CabBookingBase {

//#region cabBookingId Prop
        @prop()
        cabBookingId : number;
//#endregion cabBookingId Prop


//#region travellerId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        travellerId : number;
//#endregion travellerId Prop


//#region cabDetailId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        cabDetailId : number;
//#endregion cabDetailId Prop


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