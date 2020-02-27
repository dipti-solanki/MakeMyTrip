import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class ReviewBase {

//#region appUserId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        appUserId : number;
//#endregion appUserId Prop


//#region reviewId Prop
        @prop()
        reviewId : number;
//#endregion reviewId Prop


//#region reviewDetails Prop
        @required()
        @maxLength({value:50})
        reviewDetails : string;
//#endregion reviewDetails Prop











}