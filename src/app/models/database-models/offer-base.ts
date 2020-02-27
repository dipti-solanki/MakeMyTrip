import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class OfferBase {

//#region offerId Prop
        @prop()
        offerId : number;
//#endregion offerId Prop


//#region offerName Prop
        @required()
        @maxLength({value:50})
        offerName : string;
//#endregion offerName Prop


//#region discount Prop
        @required()
        discount : number;
//#endregion discount Prop











}