import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class CabBase {

//#region cabId Prop
        @prop()
        cabId : number;
//#endregion cabId Prop


//#region cabName Prop
        @required()
        @maxLength({value:50})
        cabName : string;
//#endregion cabName Prop


//#region cabs Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        cabs : number;
//#endregion cabs Prop



}