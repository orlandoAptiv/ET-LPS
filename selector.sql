/*
Navicat MySQL Data Transfer

Source Server         : Servidor_Mejoramientos
Source Server Version : 50553
Source Host           : dl9xdzm83:3306
Source Database       : selector

Target Server Type    : MYSQL
Target Server Version : 50553
File Encoding         : 65001

Date: 2023-03-03 16:55:24
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `etiquetas`
-- ----------------------------
DROP TABLE IF EXISTS `etiquetas`;
CREATE TABLE `etiquetas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `comando` varchar(100) DEFAULT NULL,
  `tipo_etiqueta` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of etiquetas
-- ----------------------------
INSERT INTO `etiquetas` VALUES ('1', '^XA', '1');
INSERT INTO `etiquetas` VALUES ('2', '^FO10, 70^ADN, 27, 24^FDSelector^FS', '1');
INSERT INTO `etiquetas` VALUES ('3', '^FO35,25^ADN, 27, 24^FD', '1');
INSERT INTO `etiquetas` VALUES ('4', 'NPD', '1');
INSERT INTO `etiquetas` VALUES ('5', '^FS', '1');
INSERT INTO `etiquetas` VALUES ('6', '^FO210,70^ADN, 27, 25^FD', '1');
INSERT INTO `etiquetas` VALUES ('7', 'SELECTOR', '1');
INSERT INTO `etiquetas` VALUES ('8', '^FS', '1');
INSERT INTO `etiquetas` VALUES ('9', '^FO10, 120^ADN, 27, 24^FDOpcion:^FS', '1');
INSERT INTO `etiquetas` VALUES ('10', '^FO210,120^ADN, 28, 28^FD', '1');
INSERT INTO `etiquetas` VALUES ('11', 'opcion', '1');
INSERT INTO `etiquetas` VALUES ('12', '^FS', '1');
INSERT INTO `etiquetas` VALUES ('13', '^FO330,50,^BY1.5', '1');
INSERT INTO `etiquetas` VALUES ('14', '^BCN,100,Y,N,N', '1');
INSERT INTO `etiquetas` VALUES ('15', '^FD', '1');
INSERT INTO `etiquetas` VALUES ('16', 'codigobarras', '1');
INSERT INTO `etiquetas` VALUES ('17', '^FS', '1');
INSERT INTO `etiquetas` VALUES ('18', '^FO10,175^ADN, 40, 14^FD', '1');
INSERT INTO `etiquetas` VALUES ('19', 'empalme', '1');
INSERT INTO `etiquetas` VALUES ('20', '^FS', '1');
INSERT INTO `etiquetas` VALUES ('21', '^FO130,175^ADN, 40, 14^FD', '1');
INSERT INTO `etiquetas` VALUES ('22', 'fecha', '1');
INSERT INTO `etiquetas` VALUES ('23', '^FS', '1');
INSERT INTO `etiquetas` VALUES ('24', '^FO330,175^ADN, 40, 14^FD', '1');
INSERT INTO `etiquetas` VALUES ('25', 'hora', '1');
INSERT INTO `etiquetas` VALUES ('26', '^FS', '1');
INSERT INTO `etiquetas` VALUES ('27', '^XZ', '1');

-- ----------------------------
-- Table structure for `selector`
-- ----------------------------
DROP TABLE IF EXISTS `selector`;
CREATE TABLE `selector` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `selector` varchar(45) DEFAULT NULL,
  `np` varchar(45) DEFAULT NULL,
  `opcion` varchar(45) DEFAULT NULL,
  `empalme` varchar(45) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `npc` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of selector
-- ----------------------------
INSERT INTO `selector` VALUES ('1', '1', '35572126', '02', '1850', '1', '85554057');
INSERT INTO `selector` VALUES ('2', '2', '35572127', '02', 'Ultrasonico-1850', '1', '85554058');
INSERT INTO `selector` VALUES ('3', '3', '35572128', '02', 'VC corto  ', '1', '85554063');
INSERT INTO `selector` VALUES ('4', '4', '35572129', '02', 'VC corto  ', '1', '85554064');
INSERT INTO `selector` VALUES ('5', '5', '35572130', '02', 'VC corto  ', '1', '85554065');
INSERT INTO `selector` VALUES ('6', '6', '35572131', '02', 'VC corto  ', '1', '85554067');
INSERT INTO `selector` VALUES ('7', '7', '35572132', '02', 'VC corto  ', '1', '85554068');
INSERT INTO `selector` VALUES ('8', '8', '35572133', '02', 'VC corto  ', '1', '85554069');
INSERT INTO `selector` VALUES ('9', '9', '35572135', '02', 'VC corto  ', '1', '85554071');
INSERT INTO `selector` VALUES ('10', '10', '35572137', '02', 'VC corto  ', '1', '85554073');
INSERT INTO `selector` VALUES ('11', '11', '35572138', '02', 'VC corto  ', '1', '85554074');
INSERT INTO `selector` VALUES ('12', '12', '35572139', '02', 'VC corto  ', '1', '85554075');
INSERT INTO `selector` VALUES ('13', '13', '35572140', '02', 'VC corto  ', '1', '85554076');
INSERT INTO `selector` VALUES ('14', '14', '35572141', '02', 'VC corto', '1', '85554077');
INSERT INTO `selector` VALUES ('15', '15', '35572142', '02', 'ruteo largo', '1', '85554078');
INSERT INTO `selector` VALUES ('16', '16', '35572143', '02', 'ruteo largo', '1', '85554079');
INSERT INTO `selector` VALUES ('17', '17', '35572144', '02', 'ruteo largo', '1', '85554080');
INSERT INTO `selector` VALUES ('18', '18', '35572145', '02', 'ruteo largo', '1', '85554081');
INSERT INTO `selector` VALUES ('19', '19', '35572146', '02', 'ruteo largo', '1', '85554082');
INSERT INTO `selector` VALUES ('20', '20', '35572147', '02', 'ruteo largo', '1', '85554083');
INSERT INTO `selector` VALUES ('21', '21', '35572148', '02', 'ruteo largo', '1', '85554084');
INSERT INTO `selector` VALUES ('22', '22', '35572149', '02', 'ruteo largo', '1', '85554085');
INSERT INTO `selector` VALUES ('23', '23', '35572150', '02', 'ruteo largo', '1', '85554086');
INSERT INTO `selector` VALUES ('24', '24', '35572151', '02', 'ruteo largo', '1', '85554087');
INSERT INTO `selector` VALUES ('25', '25', '35572152', '02', 'ruteo largo', '1', '85554088');
INSERT INTO `selector` VALUES ('26', '26', '35572153', '02', 'ruteo largo', '1', '85554089');
INSERT INTO `selector` VALUES ('27', '27', '35572155', '02', 'VC corto  ', '1', '85554092');
INSERT INTO `selector` VALUES ('28', '28', '35572157', '02', 'VC corto  ', '1', '85554094');
INSERT INTO `selector` VALUES ('29', '29', '35572158', '02', 'VC corto  ', '1', '85554095');
INSERT INTO `selector` VALUES ('30', '30', '35572159', '02', 'VC corto  ', '1', '85554096');
INSERT INTO `selector` VALUES ('31', '31', '35572162', '02', 'ruteo largo', '1', '85554099');
INSERT INTO `selector` VALUES ('32', '32', '35572164', '02', 'ruteo largo', '1', '85554101');
INSERT INTO `selector` VALUES ('33', '33', '35572165', '02', 'ruteo largo', '1', '85554102');
INSERT INTO `selector` VALUES ('34', '34', '35572168', '02', 'ruteo largo', '1', '85554105');
INSERT INTO `selector` VALUES ('35', '35', '35572170', '02', 'ruteo largo', '1', '85554107');
INSERT INTO `selector` VALUES ('36', '36', '35572171', '02', 'ruteo largo', '1', '85554108');
INSERT INTO `selector` VALUES ('37', '37', '35572173', '02', 'VC corto  ', '1', '85554110');
INSERT INTO `selector` VALUES ('38', '38', '35572174', '02', 'VC corto  ', '1', '85554111');
INSERT INTO `selector` VALUES ('39', '39', '35572176', '02', 'VC corto  ', '1', '85554113');
INSERT INTO `selector` VALUES ('40', '40', '35572179', '02', 'VC corto  ', '1', '85554066');
