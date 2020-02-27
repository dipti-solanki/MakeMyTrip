import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class CabDetailBase {

//#region cabDetailId Prop
        @prop()
        cabDetailId : number;
//#endregion cabDetailId Prop


//#region cabId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        cabId : number;
//#endregion cabId Prop


//#region cabDetails Prop
        @required()
        @maxLength({value:50})
        cabDetails : string;
//#endregion cabDetails Prop


//#region facilities Prop
        @required()
        @maxLength({value:50})
        facilities : string;
//#endregion facilities Prop


//#region amount Prop
        @required()
        amount : number;
//#endregion amount Prop


//#region reviewId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        reviewId : number;
//#endregion reviewId Prop


//#region origin Prop
        @required()
        @maxLength({value:50})
        origin : string;
//#endregion origin Prop


//#region destination Prop
        @required()
        @maxLength({value:50})
        destination : string;
//#endregion destination Prop







}